package multipleinheritance;

public class Class1 implements Interface1, Interface2 {

	@Override
	public void displayMessage1() {
		System.out.println("Message1");
	}

	@Override
	public void displayMessage2() {
		System.out.println("Message2");
	}
}
