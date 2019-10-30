#include "MyForm.h"
using namespace System;

using namespace System::Windows::Forms;



[STAThreadAttribute]

void Main(array< String ^> ^ args) {

	Application::EnableVisualStyles();

	Application::SetCompatibleTextRenderingDefault(false);

	pr6::MyForm MyForm;

	Application::Run(%MyForm);

}
