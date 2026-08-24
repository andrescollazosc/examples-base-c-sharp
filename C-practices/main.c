#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/*C is procedural: it has structs for data and separate functions for behavior.*/
typedef struct {
    char id[37]; /* store UUID-like string (36 chars + '\0') */
    char *dni;
    char *firstName;
    char *lastName;
} Person;

/*C memory management: reserve and initialize memory for a Person instance */
Person *person_create(void) {
    Person *p = malloc(sizeof(Person));
    if (!p) return NULL;
    p->id[0] = '\0';
    return p;
}

/*C memory management: release memory allocated for a Person instance */
void person_free(Person *p) { free(p); }

/*OOP: encapsulation of data and behavior */
void person_set_id(Person *p, const char *id) {
    if (!p) return;
    if (id) {
        strncpy(p->id, id, sizeof(p->id) - 1);
        p->id[sizeof(p->id) - 1] = '\0';
    } else {
        p->id[0] = '\0';
    }
}

const char *person_get_id(const Person *p) {
    if (!p) return NULL;
    return p->id;
}

int main() {
    printf("Hello, World!\n");

    Person *john = person_create();
    if (!john) return 1;

    /* encapsulated id access via setter/getter */
    person_set_id(john, "123e4567-e89b-12d3-a456-426614174000");
    printf("Person id: %s\n", person_get_id(john));

    person_free(john);
    return 0;
}