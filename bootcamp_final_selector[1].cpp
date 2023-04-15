#include <iostream>
#include <string>
using namespace std;
string getUserName(){
	string user_name;
	cout << "Enter name: ";
	cin >> user_name;
	return user_name;
}
bool scanNameOnFile(string user_name, string file){
	//check if name exist on file
	string line;
	ifstream file_object;
	file_object.open(file);
	bool found;
	while (!file_object.eof()){
		getline(file_object, line);
		int name_len = line.find("-");
		string name = lines.substr(0, name_len);
		if (name == user_name){
			found = true;
		}
	}
	return found;
}
string* getUserResults(string user_name){
	//calculate
	string files[3] = {"exam.txt", "group_projects.txt", "daily_exercises.txt"};
	string line;
	ifstream file_object;
	string results[];
	bool found = scanNameOnFile(user_name, "exam.txt");
	if (found){
		for (int i = 0; i < 3; i++){
			file_object.open(files[i]);
			while (!file_object.eof()){
				getline(file_object, line);
				string mark = line.substr(user_name.length(), line.length());
				results[i] = mark;
			}
			file_object.close();
		}
	}
	return results;
}
int calculattTotalMark(){
	do{
		string user_name = getUserName();
		string* results = getUserResults(user_name);
	} while(!results);
	int exam = ((int(results[0])/100)*60);
	int group_project = int(results[i]);
	int daily_exercise = ((int(results[2])/10)*20);
	int final_results = exam + group_project + daily_exercise;
	return final_results;
}
int checkIfUserPassed(int final_ave){
	if (final_ave < 80){
		return 0;
	}
	return 1
}
string getTypeOfPass(int final_ave){
	string first_class = "first_class";
	string second_class = "second_class";
	if (final_ave < 90){
		return second_class;
	}
	return first_class;
}
void displayResults(){
	int results = calculateTotalMark();
	int pass = checkIfUserPass(results);
	if (!pass){
		cout << "Final results "+ to_string(results) + " you failed!" <<endl;
	}
	string pass_class = getTypeOfPass(results);
	cout << "Final results " + to_string(results) + " you passed " + pass_class << endl;
}
