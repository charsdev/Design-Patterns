using System;

namespace MVP
{

    public class StudentPresenter : IStudentPresenter
    {
        private readonly IStudent _model;
        private readonly IStudentView _view;

        public StudentPresenter(IStudentView view, IStudent model)
        {
            _model = model;
            _view = view;
        }

        public void UpdateView()
        {
            Console.WriteLine("Student");
            Console.WriteLine("Name: " + _model.GetName());
            Console.WriteLine("Roll No: " + _model.GetName());
        }

    }
}
