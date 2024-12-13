is_valid_age = False
age = 0

# test_number = 0

# while test_number < 10:
#     print(test_number)
#     test_number += 3

while not is_valid_age:
    age_text = input("What is your age: ")
    try:
        age = int(age_text)
        is_valid_age = True
    except ValueError:
        print("That was an invalid age.")

print(f"Your age is {age}")

# while True:
#     # Run the code at least once

# while True:
#     # Runs the code 0 or more times

