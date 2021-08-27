	/**
	* Sets the mood image
	*/
	var setMood = function(nr)
	{
		// check boundaries
		if (nr < 0) nr = 0;
		if (nr > 5) nr = 5;
		// adjust image
		document.getElementById("imgMood").src = "mood" + nr + ".gif";
	}

	// start scripts
	alert("HI");
	window.addEventListener('load', function() {
		document.getElementById("selMood").addEventListener('change', function() {
			setMood(this.value);
		});
	});
