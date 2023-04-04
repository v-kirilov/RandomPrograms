$(document).ready(function () {
    // GET BY ID
    $(".btn-get-student").on("click", function () {
        var formData = new FormData();
        var studentid = $(this).attr("data-studentid");
        console.log("app.js");
        var url = '@Url.Action("GetDetailsById", "Home")' + '/' + studentid;
        $.ajax({
            type: 'GET',
            url: url,
            contentType: false,
            processData: false,
            cache: false,
            data: formData,
            success: function (response) {
                if (response.responseCode == 0) {
                    var student = JSON.parse(response.responseMessage);
                    $("#email").val(student.Email);
                    $("#name").val(student.Name);
                    $("#hdn-student-id").val(student.Id);

                }
                else {
                    alert(response.ResponseMessage);
                }
            },
            error: errorCallback
        });
    });
    //SAVE
    $("#btn-insert-student").on("click", function () {
        var formData = new FormData();
        formData.append("name", $("#name").val());
        formData.append("email", $("#email").val());
        $.ajax({
            type: 'POST',
            url: '@Url.Action("InsertStudent", "Home")',
            contentType: false,
            processData: false,
            cache: false,
            data: formData,
            success: successCallback,
            error: errorCallback
        });
    });
    // UPDATE
    $("#btn-update-student").on("click", function () {
        var formData = new FormData();
        formData.append("id", $("#hdn-student-id").val());
        formData.append("name", $("#name").val());
        formData.append("email", $("#email").val());
        $.ajax({
            type: 'PUT',
            url: '@Url.Action("UpdateStudent", "Home")',
            contentType: false,
            processData: false,
            cache: false,
            data: formData,
            success: successCallback,
            error: errorCallback
        });
    });
    //DELETE
    $("#btn-delete-student").on("click", function () {
        var formData = new FormData();
        formData.append("id", $("#hdn-student-id").val());
        $.ajax({
            type: 'DELETE',
            url: '@Url.Action("DeleteStudent", "Home")',
            contentType: false,
            processData: false,
            cache: false,
            data: formData,
            success: successCallback,
            error: errorCallback
        });
    });
    function resetForm() {
        $("#hdn-student-id").val("");
        $("#name").val("");
        $("#email").val("");
    }
    function errorCallback() {
        alert("Something went wrong please contact admin.");
    }
    function successCallback(response) {
        if (response.responseCode == 0) {
            resetForm();
            alert(response.responseMessage, function () {

                //PERFORM REMAINING LOGIC
            });
        }
        else {
            alert(response.ResponseMessage);
        }
    };
});