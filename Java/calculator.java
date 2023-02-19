import java.util.Scanner;

public class calculator {
  public static void main(String[] args) {

    try (Scanner values = new Scanner(System.in)) {
      // basic output
      System.out.println("Witaj w kalkulatorze!");

      // sleep() function
      try {
        Thread.sleep(2000);
      } catch (InterruptedException e) {
        e.printStackTrace();
      }

      System.out.println("Najpierw zacznijmy od pytań:");

      System.out.println("Jak się nazywasz?");
      String imie = values.nextLine();

      System.out.println("Jakie masz nazwisko?");
      String nazwisko = values.nextLine();

      System.out.println("Ile masz lat?");
      int wiek = Integer.parseInt(values.nextLine());

      System.out.println("Gdzie mieszkasz?");
      String miasto = values.nextLine();

      System.out.println("Do jakiej szkoły chodzisz?");
      String szkola = values.nextLine();

      System.out.println("Dobrze.");

      try {
        Thread.sleep(1000);
      } catch (InterruptedException e) {
        e.printStackTrace();
      }

      System.out.println(
          "Imie: " + imie + "\n" +
              "Nazwisko: " + nazwisko + "\n" +
              "Wiek: " + wiek + "\n" +
              "Miasto: " + miasto + "\n" +
              "Szkoła: " + szkola + "\n");

      try {
        Thread.sleep(1500);
      } catch (InterruptedException e) {
        e.printStackTrace();
      }
      System.out.println("Czy te dane są poprawne?");
      String wybor = values.nextLine();

      if (wybor.equals("Tak")) {
        System.out.println("Dobrze! Przejdzmy dalej");
      } else {
        System.out.println("No to pa. lol...");
        return;
      }
      try {
        Thread.sleep(1000);
      } catch (InterruptedException e) {
        e.printStackTrace();
      }
      System.out.println("Dobrze " + imie + " Przejdźmy do kalkulatora!");
      System.out.println("Podaj pierwszą liczbę: ");
      int num1 = Integer.parseInt(values.nextLine());
      System.out.println("Podaj drugą liczbę: ");
      int num2 = Integer.parseInt(values.nextLine());
      System.out.println("Podaj operatora: (+   -   /   *)");
      String oper = values.nextLine();

      int res;
      switch (oper) {
        case "+":
          res = num1 + num2;
          break;
        case "-":
          res = num1 - num2;
          break;
        case "*":
          res = num1 * num2;
          break;
        case "/":
          if (num2 == 0) {
            System.out.println("Nie można dzielić przez zero.");
            return;
          }
          res = num1 / num2;
          break;
        default:
          System.out.println("Niepoprawny operator.");
          return;
      }
      System.out.println("Twój wynik to: " + res);
    } catch (NumberFormatException e) {
      // TODO Auto-generated catch block
      e.printStackTrace();
    }
  }
}