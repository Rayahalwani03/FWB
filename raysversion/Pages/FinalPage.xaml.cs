using raysversion.Models;

namespace raysversion;

public partial class FinalPage : ContentPage
{

    int stuID;
    int crsID;
	public FinalPage()
	{
		InitializeComponent();
        Student_List_View.ItemsSource = App.DBTrans.GetALLStudents();
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();
	}
    private void Add_Button_Clicked(object sender, EventArgs e)
    {

        App.DBTrans.AddEnrollments(new Models.EnrollmentInfo
        {
            StudentID = stuID,
            CourseID = crsID


        });
        Enroll_List_View.ItemsSource = App.DBTrans.GetAllEnrollments();
    }

    private void Show_Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Delete_Clicked(object sender, EventArgs e)
    {

    }

    private void Student_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var student = e.Item as StudentInfo;
        stuID = student.StudentID;

    }

    private void Course_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var course = e.Item as CourseInfo;
        crsID = course.CourseID;
    }
}