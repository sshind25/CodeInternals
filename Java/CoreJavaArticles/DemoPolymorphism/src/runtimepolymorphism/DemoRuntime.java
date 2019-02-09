package runtimepolymorphism;

public class DemoRuntime {

	public static void main(String[] args) {
		//class1 holds object of Class1
		Class1 class11 = new Class1();
		class11.displayMessage();
		
		//class2 holds object of Class2
		Class1 class22 = new Class2();
		class22.displayMessage();
		
		//class22 holds object of Class2
		Class2 class33 = new Class2();
		class33.displayMessage();
	}

}
