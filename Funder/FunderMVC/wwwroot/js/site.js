function doProjectCreate() {

    actionMethod = "POST"
    actionUrl = "/user/project"
    sendData = {
        "ProjectName": $('#ProjectName').val(),
        "Description": $('#Description').val(),
        "Goal": $('#Goal').val(),
        
        "Category": $('#Category').val()     
        
    }

    $.ajax({
        url: actionUrl,
        dataType: 'json',
        type: actionMethod,
        data: JSON.stringify(sendData),

        contentType: 'application/json',
        processData: false,
        success: function (data, textStatus, jQxhr) {
          //  $('#responseDiv').html("The update has been made successfully");
            alert("Project Created")
        },
        error: function (jqXhr, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });


}



