// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
  $(document).ready(function(){
          $( "#exibir" ).click(function() {
              var url = "/Hora/DataHora";
              $.post(url, true, function (data)
              {
                $("#rData").html(data);
               });
   });   });