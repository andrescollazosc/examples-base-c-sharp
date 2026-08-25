class Main{
    public static void main(String[] args) {
        System.out.println("Hello, World!");
    }
}

class Person{
        private String name;
        private String lastName;
        private String dni;

        public Person(String name, String lastName, String dni) {
            this.name = name;
            this.lastName = lastName;
            this.dni = dni;
        }

        // Getters and setters
        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public String getLastName() {
            return lastName;
        }

        public void setLastName(String lastName) {
            this.lastName = lastName;
        }

        public String getDni() {
            return dni;
        }

        public void setDni(String dni) {
            this.dni = dni;
        }
    }