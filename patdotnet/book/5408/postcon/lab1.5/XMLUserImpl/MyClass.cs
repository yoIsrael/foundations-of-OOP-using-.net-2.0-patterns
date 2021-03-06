// project created on 9/24/2004 at 8:24 PM
using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using DbgMgr;

namespace XMLUserImpl {

	[System.Xml.Serialization.XmlRootAttribute( "user", Namespace="urn:devspace.com")]
	public class User : UserReference.IUser {
		private string _name;
		private string _street;
        private string _city;
		private string _country;
		
		[System.Xml.Serialization.XmlElement( "name")]
		public string name {
			get { return _name; }
			set { _name = value; }
		}
		[System.Xml.Serialization.XmlElement( "street")]
		public string street {
			get { return _street; }
			set { _street = value; }
		}		
		[System.Xml.Serialization.XmlElement( "city")]
        public string city {
            get { return _city; }
            set { _city = value; }
        }
		[System.Xml.Serialization.XmlElement( "country")]
        public string country {
            get { return _country; }
            set { _country = value; }
        }
	}

    public class Operations : UserReference.IOperations {
        // Function that will help you figure out what the local directory is.
        private void GetLocalDirectory() {
            DebugMgr.start( 9, "XMLUserImpl.Operations.GetLocalDirectory");
            DebugMgr.outputVar( 9, "Local Directory", Directory.GetCurrentDirectory());
            DebugMgr.end( 9);
        }
        public UserReference.IUser LoadUser( string reference) {
            DebugMgr.start( 9, "XMLUserImpl.Operations.LoadUser");
            DebugMgr.outputVar( 9, "Reference", reference);
            GetLocalDirectory();
            UserReference.IUser user = null;
            if( reference == "some.identifier") {
                user = new User();
                XmlSerializer reader = new XmlSerializer( user.GetType());
                StreamReader file= new StreamReader( Directory.GetCurrentDirectory() + "/some.identifier.xml");

                user = (User)reader.Deserialize( file);
            }
            DebugMgr.end( 9);
            return user;
        }
    }
}

namespace Reference {
    public class Implementation : UserReference.IImplementations {
        public Object GetResource( string prefix, string resource, string view) {
            if( prefix == "XML") {
                return new XMLUserImpl.Operations();
            }
            else {
                return null;
            }
        }
    }
}


