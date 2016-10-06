using System;
using System.IO;

namespace DbUserImpl {
    class User : UserReference.IUser {
        string _name;
        string _street;
        string _city;
        string _country;
        
        public string name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }
        public string street {
            get {
                return _street;
            }
            set {
                _street = value;
            }
        }
        public string city {
            get {
                return _city;
            }
            set {
                _city = value;
            }
        }
        public string country {
            get {
                return _country;
            }
            set {
                _country = value;
            }
        }
    }
    
    public class Operations : UserReference.IOperations {
        // Notice how the Operations object is responsible for loading the
        // User object.  Classical OO dictates elsewise, but component
        // engineering prefers separation.
        public UserReference.IUser LoadUser( string reference) {
            UserReference.IUser user = null;
            if( reference == "some.identifier") {
                user = new User();
                StreamReader sr = new StreamReader( @"some.identifier.txt");
                user.name = sr.ReadLine();
                user.street = sr.ReadLine();
                user.city = sr.ReadLine();
                user.country = sr.ReadLine();
            }
            return user;
        }
    }
}