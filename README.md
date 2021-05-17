# Konrad-Gadela---Job-Assignment

// TODO: Implement a simple server that can process incoming requests and respond with apropriate responses
		// Requests are strings containing one command and optionally command arguments.
		
		// There are two commands:
		// PING - responds with "Pong"
		// ECHO [argument] - responds with the value of the argument, example: "ECHO Foo" -> "Foo"

		// Requests that cannot be parsed as valid commands should return "Bad request"
		
		// In additon there are two command modifiers that the server can be initialized with:
		// TIME - adds a timestamp before the response of all command: "PING" -> "10:20:03 Pong"
		// TOUPPER - converts the response of all commands to uppercase, example: "ECHO Foo" -> "FOO"
				
		// When implementing the server, assume that the list of both commands and modifiers will be extended in the future.
		
		// Note: This task is not about implementing HTTP server but rather providing an implementation of Server class
		// Note: Code can be provided in any way that you prefer. You don't need to use dotnetfiddle.net
