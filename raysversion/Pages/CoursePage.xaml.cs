namespace raysversion;

public partial class CoursePage : ContentPage
{
	public CoursePage()
	{
		InitializeComponent();
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();

    }

    private void Add_Button_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddCourses(new Models.CourseInfo
        {
            CourseName = Course_Name.Text,
            CourseCode = Course_Code.Text


        });

    }

    private void Show_Button_Clicked(object sender, EventArgs e)
    {
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();


    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteCourses((int)button.BindingContext);
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();



    }
}