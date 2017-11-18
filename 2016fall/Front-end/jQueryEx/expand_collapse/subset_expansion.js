$(document).ready(function() {
	$("#jdom a").toggle(
		function() {
		    $(this).prev().show();
		    $(this).text("Show less");
	    },
		function() {
		    $(this).prev().hide();
		    $(this).text("Show more");
	    }
	); // end toggle 
}); // end ready