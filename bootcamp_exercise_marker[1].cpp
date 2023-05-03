#include <iostream>
#include <string>
using namespace std;
//mark students daily exercises
string* getAllQuestions(){
	// load questions from a file
	string line;
	ifstream file_object;
	string questions[];
	file_object.open("questions.txt");
	if (file_object.is_open()){
		while (!file_object.eof()){
			getline(file_object, line);
			questions[sizeof(questions])] = line;
		}
	}
	return questions;
}
string* deleteStringElement(string element[], int index){
	//get a string subset
	string new_element[sizeof(elements) - 1];
	for (int i = 0; i < elements.length(); i++){
		if (i == index){
			continue;
		}
		else {
			new_elements[sizeof(new_elements)] = elements[i];
		}
	}
	return new_elements;
}
char* getAnswers(string questions[]){
	//let user fill in answers
	char response;
	char answers[];
	for (int i = 0; i < questions.length(); i++){
		cout << questions[i];
		cin >> response;
		answers[i] = response;
	}
	return answers;
}
void questionUser(string questions[], char solutions[]){
	//Question user, mark answers and give response
	while (sizeof(question) != 0){
		int indexes[];
		char* answers = getAnswers(questions);
		for (int i = 0; i < answers.length(); i++){
			if (answers[i] == solutions[i]){
				indexes[sizeof(indexes)] = i;
			}
		}
		for (int j = 0; j < indexes.length(); j++){
			string* questions = deleteStringElement(questions, j);
			char* = deleteCharArrayElement(solution, j);
		}
		if (indexes.length() == 0){
				cout << "You got all questions right!" << endl;
		}
		else{
			cout << "You got " + to_string(sizeof(index)) + " right!" << endl;
		}
	}
}
