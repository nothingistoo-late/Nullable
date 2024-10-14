namespace NullableTester
{
    // trong khuôn viên namespace chỉ chứa các class và những thằng ngang cơ class: INTERFACE, DELEGATES
    // có thể khai báo class gộp chung trong 1 tập tin vật lí như bài này hoặc tách riêng mỗi class 1 tập tin .cs riêng 
    // nhưng chung hay riêng thì đều phải khai báo hộ khẩu nhà ở hộ khẩu nào ~ namespace nào??
    // nha sĩ khuyên dùng: trừ tình huống đặc biệt nào đó không biết thì nên tách mỗi class 1 tập tin .cs cho dễ dàng quản lí src code 
    // và khai báo chung 1 namespace
    // 1 project có nhiều namespace !!! DAO, DTO, Controller 
    // Dao, DAO, DTO, Dto

    

    public class Student
    {   // phá OOP 1 xíu kh dùng ENCAPSULATION  
        // mặc áo xuyên thấu 
        public string? id;
        public string? name;
        public int job;
        public double gpa;
        // không che giấu thông tin, public = ai cũng thấy ~ bài viết public, biography public
        public void FlexProfile()
        {
            Console.WriteLine("ID := " + id);
            Console.WriteLine("Name := {0}",name);
            Console.WriteLine($"job := {job}");
            Console.WriteLine($"GPA := {gpa}");
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student? s = new Student();
            // biến obj    object: vùng ram chứa infor của object 
            // new: xin vùng ram bự ~ malloc() bên C 
            // 
            s.id = "SE181597";
            s.name = "TRUNG";
            s.job = 2004;
            s.gpa = 8.6;
            s.FlexProfile();

            // biến object = null nghĩa là trỏ vào đáy ram không có code ửo đó đâu, nếu chấm 1 cái gì đó tức là gọi hàm của class sẽ bị exception null reference do đáy ram kh có code để mà chạy 
            // dùng null để làm gì: để hủy vùng object đã new, do biến đã trỏ sang vùng khác, diều đứt dây. 
            // -Dùng trong tình huống biến đang kh trỏ object nào
            // 2.1: khi bạn search 1 object trong list, tìm 1 sv trong 5000 ae
            // tìm kh thấy thì trả về null 
            // s = null; return s;

            //exception 
            // dùng toán tử is null == null và != null để check biến đang kh trỏ vào ai hay không 

            s = null;
            if (s is null)
                Console.WriteLine("No student is spectified\n" +
                    "Nothing to print");
            else
                s.FlexProfile();

            // trong db có khái niệm null trên cell (hàng và cột giao nhau), cột điểm PE, điểm TE

            // null mang ý nghĩa rằng cột/cell đó có value nhưng chưa biết chính xác là value gì, từ từ sẽ có, chưa xác định rồi sẽ có

            // có 1 cái gì đó diễn tả trạng thái tạm thời bỏ trống, sau đó sẽ điền vào sau

            // null là 1 trạng thái, tình trạng của cột dữ liệu chưa xác định đc value !!

            // ánh xạ ngược lên code(code class student đc map thành dòng trong table) làm sao để diễn tả cột điểm ch xác định trong lập trình??

            //double pe = null; // biến primitive - giá trị đơn kh có khái niệm null - giá trị phải là con số, cái chữ nào đó !! kh diễn tả đc trạng thái em chưa có gì, em chưa xác định

            //Java: int -> Integer mang null như thường (wrapper class)

            // long Long, double Double, char Character;
            // 
            //C#: dùng toán tử/ keyword/ kí hiệu ? đi kèm primitive/ value-type giúpp mở rộng promitive cho phép giá trị null

            double ? pe = null; // y chang double, chỉ thêm value null. ta xài is null == null != null như truyền thồng để check điểm

            pe = 8.6;

            if (pe == null)
                Console.WriteLine("điểm chưa có em ơi, chờ đi bé !!!");
            else
                Console.WriteLine("Điểm nè em: " + pe);

            // ? gắn với các data type/ primitive/ value-type sẽ giúp các biến của các loại data-type mới này đc mang thêm giá trị null mang ú nghĩa chưa xác định chính xác value, từ từ sẽ có

            // ta có: int? long? float? double? char? bool?
            // đám này dc gọi là nullabe data-type 
            //em có thẻ mang giá trị null ngoài giá trị truyền thồng
            
            // vậy Student? s; Lecture? l; Product? p;
            //     Student  s; Lecture l ; Product  p;
            //? không là vấn đề vì biến object sinh ra đã sẵn dc mang null mà kh cần ?

            // đôi khi mình cần Student? vì ide hay warning khi mình gán s = null;

            // hàm search hay dùng null để nói rằng chưa biết hay kh tìm thấy

            // value == null để nói rằng thông tin của biến tạm thời chưa xác định
            //
        }

    }
}
