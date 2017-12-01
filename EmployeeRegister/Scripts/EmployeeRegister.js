/*--------------------the search function---------------------------------*/
function SearchFunction() {
    // Declare variables 
    var input, filter, table, tr, td, i;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("myTable");
    tr = table.getElementsByTagName("tr");

    // Loop through all table rows, and hide those who don't match the search query
    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[0];
        if (td) {
            if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}
/*------------------------------------------------------*/
function deleteRow() {
    var x = confirm("Are you sure you want to delete this employee from the list?")
    if (x == true) { return true;}
    else {return false;}
}
/*---------------From here start the search message's------------------*/
$(document).ready(function () {
    $(".search").keyup(function () {
        var searchTerm = $(".search").val();
        var listItem = $('.results tbody').children('tr');
        var searchSplit = searchTerm.replace(/ /g, "'):containsi('")

        $.extend($.expr[':'], {
            'containsi': function (elem, i, match, array) {
                return (elem.textContent || elem.innerText || '').toLowerCase().indexOf((match[3] || "").toLowerCase()) >= 0;
            }
        });

        $(".results tbody tr").not(":containsi('" + searchSplit + "')").each(function (e) {
            $(this).attr('visible', 'false');
        });

        $(".results tbody tr:containsi('" + searchSplit + "')").each(function (e) {
            $(this).attr('visible', 'true');
        });

        var jobCount = $('.results tbody tr[visible="true"]').length;
        $('.counter').text(jobCount + ' item');

        if (jobCount == '0') { $('.no-result').show(); }
        else { $('.no-result').hide(); }
    });
});

/*---------------Table sorting------------------*/

//function sortTable(n) {
//    var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
//    table = document.getElementsByClassName("tableSort");
//    switching = true;

//    dir = "asc";

//    while (switching) {

//        switching = false;
//        rows = table.getElementsByTagName("TR");

//        for (i = 1; i < (rows.length - 1) ; i++) {

//            shouldSwitch = false;

//            x = rows[i].getElementsByTagName("TD")[n];
//            y = rows[i + 1].getElementsByTagName("TD")[n];

//            if (dir == "asc") {
//                if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {

//                    shouldSwitch = true;
//                    break;
//                }
//            } else if (dir == "desc") {
//                if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {

//                    shouldSwitch = true;
//                    break;
//                }
//            }
//        }
//        if (shouldSwitch) {

//            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
//            switching = true;

//            switchcount++;
//        } else {

//            if (switchcount == 0 && dir == "asc") {
//                dir = "desc";
//                switching = true;
//            }
//        }
//    }
//};