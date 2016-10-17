namespace TestingDemo {

    public class User {
        public string LoginName { get; set; }
    }

    public interface IUserRepository {
        void Add(User newUser);
        User FetchByLoginName(string loginName);
        void SubmitChanges();
    }

    public class DefaultUserRepository : IUserRepository {

        public void Add(User newUser) {
            // implement me
        }

        public User FetchByLoginName(string loginName) {
            // implement me
            return new User() { LoginName = loginName };
        }

        public void SubmitChanges() {
            // implement me
        }
    }
}