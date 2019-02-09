package compiletimepolymorphism;

public class DemoCompileTime {

	public static void main(String[] args) {
		Employee employee = new Employee(1, "Sam");
		employee.displayInfo();
		employee.displayInfo(2);
		employee.displayInfo("John");
	}

}
