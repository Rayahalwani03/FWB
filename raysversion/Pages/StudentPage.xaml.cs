namespace raysversion;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
        Student_List_View.ItemsSource= App.DBTrans.GetALLStudents();
	}

    private void Add_Button_Clicked(object sender, EventArgs e)
    {

        App.DBTrans.AddStudents(new Models.StudentInfo
        {
            StudentName = Student_Name.Text,
            StudentDepartment = Student_Department.Text


        });

    }

    private void Show_Button_Clicked(object sender, EventArgs e)
    {

        Student_List_View.ItemsSource = App.DBTrans.GetALLStudents();

    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteStudents((int)button.BindingContext);
        Student_List_View.ItemsSource = App.DBTrans.GetALLStudents();

    }
}