$(document).ready(function(){
	$("#ComboLiga").change(function () { 
		$("#ComboLiga option:selected").each(function () {
			id_liga= $(this).val();
			$.post(base_url+"/board/selectorHome", { id_liga: id_liga }, function(data){
				$("#selector1").html(data);
			});            
		});
	});
});