package demoConstructors;

public class ConstructorDemo {

	public static void main(String[] args) {
		//Creating object using parameterized constructor
		Employee employee = new Employee(1,  "Sam", "Mechanical");
		employee.DisplayInfo();
		
		//Creating object using parameterless constructor
		Employee employee2 = new Employee();
		employee2.DisplayInfo();
	}

}
