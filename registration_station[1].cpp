#include <iostream>
#include <string>
using namespace std;
string getUserDetails(){
	// get students basic informaton 
	string details;
	string line;
	string user_name;
	bool found = false;
	do{
		ifstream file_object.open("details.txt");
		cout << "Enter user name: ";
		cin >> user_name;
		if (file_object.is_open()){
			while (!file_object.is_eof()){
				getline(file_object, line);
				string sub_string;
				sub_string = line.substr(0, user_name.length());
				if (sub_string == user_name){
					found = true;
					details = line;
				}
			}
			file_object.close();
		}
	}while (!found);
	return details;
}
string correctOrIncorrect(){
	//check if details are correct
	string details;
	details = getUserDetails();
	int dash_line = details.find("-");
	string other_details = details.substr(0, dash_line);
	cout << other_details + "\n";
	cout << "Are details (correct or incorrect)?: ";
	string answer;
	cin >> answer;
	return answer;
}
