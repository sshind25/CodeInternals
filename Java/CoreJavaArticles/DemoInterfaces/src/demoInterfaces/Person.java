package demoInterfaces;

//implements ConsoleOutput interface
public class Person implements ConsoleOutput {
	//then its mandatory to implement the method declared in an interface
	//else the program won't even compile
	@Override
	public void displayInfo() {
		System.out.println("Hello Person");
	}

}
