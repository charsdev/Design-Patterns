using System;

namespace MVP
{

    public class StudentController
    {
        private readonly Student _model;
        private readonly StudentView _view;

        public StudentController(Student model, StudentView view)
        {
            _model = model;
            _view = view;
        }

        public void SetStudentName(string name)
        {
            _model.SetName(name);
        }

        public string getStudentName()
        {
            return _model.GetName();
        }

        public void SetStudentRollNo(string rollNo) 
        { 
            _model.SetRollNo(rollNo);
        }

        public string getStudentRollNo()
        {
            return _model.GetRollNo();
        }

        public void UpdateView()
        {
           _view.PrintStudentDetails(_model.GetName(), _model.GetRollNo());
        }
    }
}
