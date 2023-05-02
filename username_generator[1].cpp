#include <iostream>
#include <string>
using namespace std;
string VALID_CAMPUSES[] = {"JHB", "CPT", "DBN"};
int VALID_COHORT = 2022;
void getName(string &name, string prompt_message){
	bool no_digit = false;
	while (!no_digit){
		cout << prompt_message;
		cin >> name;
		for (int i = 0; i < name.length(); i++){
			if (isdigit(name[i])){
					break;
			}
			if ((i + 1) == name.length()){
				no_digit = true;
			}
		}
	}
}
void getCampus(string &campus){
	bool campus_valid = false;
	while (!campus_valid){
		cout << "Enter campus: ";
		cin >> campus;
		for (int i = 0; i < sizeof(VALID_CAMPUSES); i++){
			if (campus == VALID_CAMPUSES[i]){
				campus_valid = true;
			}
		}
	}
}
void getCohort(int &cohort){
	//check if the cohort that the user is appyling to is valid
	bool cohort_valid = false;
	while (!cohort_valid){
		cout << "Enter cohort year: ";
		cin >> cohort;
		if (VALID_COHORT == cohort)
			cohort_valid = true;
	}
}
string generateUsername(string f_name, string l_name, string campus, int cohort){
	//user all the parameters received to generate username
	string sub_f_name;
	if (f_name.length() >= 3){
		sub_f_name = f_name.substr(f_name.length() - 3, 3);
	}
	else{
		sub_f_name = f_name + "o";
	}
	string sub_l_name;
	if (l_name.length() >= 3){
		sub_l_name = l_name.substr(0, 3);
	}
	else{
		sub_l_name = l_name + "o";
	}
	string name = sub_f_name + sub_l_name + campus + to_string(cohort);
	return name;
}
int main(){
	string first_name;
	string last_name;
	string campus;
	int cohort_year;
	getName(first_name, "Enter first name: ");
	getName(last_name, "Enter last name: ");
	getCampus(campus);
	getCohort(cohort_year);
	string user_name = generateUsername(first_name, last_name, campus, cohort_year);
	cout << user_name <<endl;
	return 0;
}
