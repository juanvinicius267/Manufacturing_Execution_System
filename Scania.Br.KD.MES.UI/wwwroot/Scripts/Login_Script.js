(function () {

    var urlBase = "https://localhost:44322/"
    var urlBaseApiLogin = "http://localhost:4000/"
    $(document).ready(function () {
        setInterval(function () {
            var checkToken = isAuthenticated();
            if ((localStorage['token'] !== "" ||
                localStorage['token'] !== "undefined" ||
                localStorage['token'] !== null) &&
                checkToken == true) {
                window.location.href = urlBase + "Login/Main";
            };
        }, 500);
       
    });
    //send credencials
    $("#btnEnviar").on('click', function () {
        var data = {
            username: $("#username").val(),
            password: $("#password").val()
        };
        data = JSON.stringify(data);
        CheckLogin(data);
    });
    //Logon on Mes System
    function CheckLogin(_data) {
        $.ajax({

            url: urlBaseApiLogin + 'Users',
            type: 'POST',
            contentType: 'application/json',
            data: _data,
            success: function (result) {   
                document.cookie = result;
                localStorage['token'] = result;
            },
            error: function (request, error) {
                alert("Request: " + JSON.stringify(request));
            }
        });
    }

    //Check IF JWT is expired and decode.
    function isAuthenticated() {
        //Decode token JWT
        var current_time = Date.now() / 1000;
        const token = localStorage.getItem('token');
        var base64Url = token.split('.')[1];
        var base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
        var jsonPayload = decodeURIComponent(atob(base64).split('').map(function (c) {
            return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
        }).join(''));
        //Parse information in Json format
        data = JSON.parse(jsonPayload);        
        //Compare actual date with JWT EXP
        if (current_time > data.exp) {
            return false;
            localStorage['token'] = null;
            document.cookie = null;
        } else {
            return true;
        }
    }
})()