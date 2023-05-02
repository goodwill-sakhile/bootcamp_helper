#include <iostream>
#include <string>
using namespace std;

string * studentList(){
	string student_list[];
	student_list[0] = "elomkhDBN2022-4April-DBN Physical-seat 3";
	student_list[1] = "elomkhCPT2022-23May-CPT physical seat 4";
	student_list[2] = "elomkhNW2022-NW physical-seat 5";
	student_list[3] = "ddhhJHB2022-2May-CPT Virtual";
	return student_list;
}
string* seperateStudentByLocation(string students, string location){
	//determine where the students come from and separate them according to their location
	string place;
	for (int i = 0; i < students.length(); i++){
		location_index = students.find(location);
		place[sizeof(place)] = students.substr(location_index, location.length());
	}
	return place;
}
string* formTeams(string* students){
	int team_number = 1;
	string teams[][];
	for (int i = 0; i < students.length(); ){
		for (int j = 0; j < team_number; j++){
			teams[i][j] = students[i];
		}
		i = i + team_number;
	}
	return teams;
}

string* dbnCampusStudents(string students[]){
	string* dbn_students = seperateStudentsByLocation(students, "DBN");
	return dbn_students;
}
string* cptCampusStudents(string students[]){
	string* cpt_students = seperateStudentsByLocation(students, "CPT");
	return cpt_students;
}
string* jhbCampusStudents(string students[]){
	string* jhb_students = seperateStudentsByLocation(students, "JHB");
	return jhb_students;
}
string* nwCampusStudents(string students[]){
	string nw_students = seperateStudentsByLocation(students, "NW");
}
string* dbnPhysicalStudents(string students[]){
	string* dbn_physical_students = seperateStudentByLocation(students, "DBN Physical");
	return dbn_physical_students;
}
string* cptPhysicalStudents(string student[]){
	cpt_physical_students = seperateStudentByLocation(students, "CPT Physical");
	return cpt_physical_students;
}
string* jhbPhysicalStudents(string students[]){
	string* jhb_physical_student = seperateStudentsByLocation(students, "JHB Physical");
	return jhb_physical_students;
}
string* nwPhysicalStudents(string students[]){
	string* nw_physical_students = seperateStudentsByLocation("NW Physical");
	return nw_physical_students;
}
string* getVirtualStudents(string students[]){
	string* virtual_students = seperateStudentsByLocation(students, "Virtual");
	return virtual_students;
}
string* dbnPhysicalTeams(string students[]){
	string* teams = formTeams(students);
	return teams;
}
string* cptPhysicalTeams(string students[]){
	string* teams = formTeams(students);
	return teams;
}
string* jhbPhysicalTeams(string students[]){
	string* teams = formTeams(students);
	return teams;
}
string* nwPhysicalTeams(string students[]){
	string* teams = formTeams(students);
	return teams;
}
string* virtualTeams(string students[]){
	string* teams = formTeams(students);
	return teams;
}
void outputOnTextFile(string file_name, string campus_teams[]){
	ofstream file_object;
	file_object.open(file_name);
	for (int i = 0; i < sizeof(campus_teams); i++){
		file_object << to_string(campus_teams[i]) + "\n";
	}
	file_object.close();
}
void dbnTeamsFile(string students_teams[]){
	outputOnTextFile("dbn_campus.txt", students_teams);
}
void cptTeamsFile(string students_teams[]){
	outputOnTextFile("cpt_campus.txt", students_teams);
}
void nwTeamsFile(string students_teams[]){
	outputOnTextFile("nw_campus.txt", students_teams);
}
void jhbTeamsFile(string students_teams[]){
	outputOnTextFile("jhb_campus.txt", students_teams);
}
void virtualTeamsFile(string students_teams[][]){
	outputOnTextFile("virtual_campus.txt", students_teams);
}

