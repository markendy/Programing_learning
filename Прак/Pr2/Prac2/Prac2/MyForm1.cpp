#include "MyForm1.h"
using namespace System;
using namespace System::Windows::Forms;

[STAThread]
void main(array<String^>^ arg) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Prac2::MyForm1 form; //WinFormsTest - ��� ������ �������
	Application::Run(% form);
}