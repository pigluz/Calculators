fun main() {
    println("Witaj w kalkulatorze!")
    Thread.sleep(2000)

    println("Najpierw zacznijmy od pytań:")

    // User input starts
    println("Jak się nazywasz?")
    val imie = readln()

    println("Jakie masz nazwisko?")
    val nazwisko = readln()

    println("Ile masz lat?")
    val wiek = readln()

    println("Gdzie mieszkasz?")
    val miasto = readln()

    println("Do jakiej szkoły chodzisz?")
    val szkola = readln()

    println("Dobrze.")

    Thread.sleep(1000)

    // Summary of the user's data
    println(
                "Imie: " + imie + "\n" +
                "Nazwisko: " + nazwisko + "\n" +
                "Wiek: " + wiek + "\n" +
                "Miasto: " + miasto + "\n" +
                "Szkoła: " + szkola + "\n")

    println("Czy te dane są poprawne?")
    val wybor = readln()

    if (wybor == "Tak") {
        println("Dobrze! Przejdżmy dalej")
    } else {
        print("No to pa. lol...")
        return
    }

    Thread.sleep(1000)
    // Calculator begins
    println("Podaj pierwszą liczbę:")
    val num1 = Integer.parseInt(readln())
    println("Podaj drugą liczbę:")
    val num2 = Integer.parseInt(readln())
    println("Podaj operator: ( +  -  /  *  )")
    val oper = readln()

    // switch function
    when (oper){
        "+" -> {
            val wynik = num1 + num2
            println("Twój wynik to: $wynik")
        }

        "-" -> {
            val wynik = num1 - num2
            println("Twój wynik to: $wynik")
        }

        "*" -> {
            val wynik = num1 * num2
            println("Twój wynik to: $wynik")
        }
        "/" -> {
        val wynik = num1 / num2
        println("Twój wynik to: $wynik")
        }

        else -> println("Niepoprawny operator.")
}}