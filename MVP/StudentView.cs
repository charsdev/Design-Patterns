using System;

namespace MVP
{

    public class StudentView : IStudentView
    {
        private IStudentPresenter _presenter;

        public StudentView(Student student)
        {
            _presenter = new StudentPresenter(this, student);

        }

        public void Print()
        {
            _presenter.UpdateView();

        }
    }
}
