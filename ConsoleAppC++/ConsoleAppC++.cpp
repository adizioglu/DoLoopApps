#include <iostream>
#include <string>

int main() {
    bool isValidAge;
    int age;
    //int testNumber = 0;

    //do
    //{
    //    std::cout << testNumber << std::endl;
    //    testNumber += 3;
    //} while (testNumber < 10);

    do {
        std::cout << "What is your age: ";
        std::string ageText;
        std::getline(std::cin, ageText);

        try {
            age = std::stoi(ageText);
            isValidAge = true;
        }
        catch (std::invalid_argument&) {
            isValidAge = false;
            std::cout << "That was an invalid age." << std::endl;
        }
    } while (!isValidAge);

    std::cout << "Your age is " << age << std::endl;

    //do
    //{
    //    // Run the code at least once
    //} while (true);

    //while (true)
    //{
    //    // Runs the code 0 or more times
    //}

    return 0;
}
