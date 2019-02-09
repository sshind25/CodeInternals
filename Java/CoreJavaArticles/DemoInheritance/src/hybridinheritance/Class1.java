package hybridinheritance;

public class Class1 implements Interface2, Interface3 {

	@Override
	public void displayMessage1() {
		System.out.println("Message1");
	}

	@Override
	public void displayMessage2() {
		System.out.println("Message2");
	}
	
	@Override
	public void displayMessage3() {
		System.out.println("Message3");
	}


}
