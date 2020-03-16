// TSLib - A free TeamSpeak 3 and 5 client library
// Copyright (C) 2017  TSLib contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the Open Software License v. 3.0
//
// You should have received a copy of the Open Software License along with this
// program. If not, see <https://opensource.org/licenses/OSL-3.0>.
// <auto-generated />







using System;
using System.Threading.Tasks;
using TSLib.Commands;
using TSLib.Messages;

namespace TSLib
{
	partial class TsBaseFunctions
	{

	/// <summary>
	/// Sends a TS-command.
	/// 
	/// 
	/// </summary>
	/// <param name="command">The command name.</param>
	/// <param name="parameter">The parameters to be added to this command.
	/// See <see cref="CommandParameter"/>, <see cref="CommandOption"/> or <see cref="CommandMultiParameter"/> for more information.</param>
	/// 
	/// 
	public R<ResponseDictionary[], CommandError> Send(string command, params ICommandPart[] parameter)
		=> Send<ResponseDictionary>(new TsCommand(command, parameter));

	/// <summary>
	/// Sends a TS-command.
	/// 
	/// 
	/// </summary>
	/// <param name="command">The command name.</param>
	/// <param name="parameter">The parameters to be added to this command.
	/// See <see cref="CommandParameter"/>, <see cref="CommandOption"/> or <see cref="CommandMultiParameter"/> for more information.</param>
	/// 
	/// <returns>Returns an enumeration of the deserialized and split up in <see cref="T"/> objects data.</returns>
	public R<T[], CommandError> Send<T>(string command, params ICommandPart[] parameter) where T : IResponse, new()
		=> Send<T>(new TsCommand(command, parameter));

	/// <summary>
	/// Sends a TS-command.
	/// 
	/// The response (if any) is not deserialized and is discarded.
	/// </summary>
	/// <param name="command">The command name.</param>
	/// <param name="parameter">The parameters to be added to this command.
	/// See <see cref="CommandParameter"/>, <see cref="CommandOption"/> or <see cref="CommandMultiParameter"/> for more information.</param>
	/// 
	/// 
	public E<CommandError> SendVoid(string command, params ICommandPart[] parameter)
		=> Send<ResponseVoid>(new TsCommand(command, parameter));

	/// <summary>
	/// Sends a TS-command.
	/// 
	/// The response (if any) is not deserialized and is discarded.
	/// </summary>
	/// <param name="command">The command name.</param>
	/// <param name="parameter">The parameters to be added to this command.
	/// See <see cref="CommandParameter"/>, <see cref="CommandOption"/> or <see cref="CommandMultiParameter"/> for more information.</param>
	/// 
	/// 
	public E<CommandError> SendVoid(TsCommand com)
		=> Send<ResponseVoid>(com);

	/// <summary>
	/// Sends a TS-command.
	/// This will send a normal query-command when connected via query client. When connected as a full client the first specified notification is used as the response.
	/// 
	/// </summary>
	/// <param name="command">The command name.</param>
	/// <param name="parameter">The parameters to be added to this command.
	/// See <see cref="CommandParameter"/>, <see cref="CommandOption"/> or <see cref="CommandMultiParameter"/> for more information.</param>
	/// <param name="type">The notification type to wait for and serialize to when called from the full client.</param>
	/// 
	public R<ResponseDictionary[], CommandError> SendHybrid(string command, NotificationType type, params ICommandPart[] parameter)
		=> SendHybrid<ResponseDictionary>(new TsCommand(command, parameter), type);

	/// <summary>
	/// Sends a TS-command.
	/// This will send a normal query-command when connected via query client. When connected as a full client the first specified notification is used as the response.
	/// 
	/// </summary>
	/// <param name="command">The command name.</param>
	/// <param name="parameter">The parameters to be added to this command.
	/// See <see cref="CommandParameter"/>, <see cref="CommandOption"/> or <see cref="CommandMultiParameter"/> for more information.</param>
	/// <param name="type">The notification type to wait for and serialize to when called from the full client.</param>
	/// <returns>Returns an enumeration of the deserialized and split up in <see cref="T"/> objects data.</returns>
	public R<T[], CommandError> SendHybrid<T>(string command, NotificationType type, params ICommandPart[] parameter) where T : class, IResponse, new()
		=> SendHybrid<T>(new TsCommand(command, parameter), type);

	/// <summary>
	/// Sends a TS-command.
	/// 
	/// 
	/// </summary>
	/// <param name="command">The command name.</param>
	/// <param name="parameter">The parameters to be added to this command.
	/// See <see cref="CommandParameter"/>, <see cref="CommandOption"/> or <see cref="CommandMultiParameter"/> for more information.</param>
	/// 
	/// 
	public async Task<R<ResponseDictionary[], CommandError>> SendAsync(string command, params ICommandPart[] parameter)
		=> await SendAsync<ResponseDictionary>(new TsCommand(command, parameter)).ConfigureAwait(false);

	/// <summary>
	/// Sends a TS-command.
	/// 
	/// 
	/// </summary>
	/// <param name="command">The command name.</param>
	/// <param name="parameter">The parameters to be added to this command.
	/// See <see cref="CommandParameter"/>, <see cref="CommandOption"/> or <see cref="CommandMultiParameter"/> for more information.</param>
	/// 
	/// <returns>Returns an enumeration of the deserialized and split up in <see cref="T"/> objects data.</returns>
	public async Task<R<T[], CommandError>> SendAsync<T>(string command, params ICommandPart[] parameter) where T : IResponse, new()
		=> await SendAsync<T>(new TsCommand(command, parameter)).ConfigureAwait(false);

	/// <summary>
	/// Sends a TS-command.
	/// 
	/// The response (if any) is not deserialized and is discarded.
	/// </summary>
	/// <param name="command">The command name.</param>
	/// <param name="parameter">The parameters to be added to this command.
	/// See <see cref="CommandParameter"/>, <see cref="CommandOption"/> or <see cref="CommandMultiParameter"/> for more information.</param>
	/// 
	/// 
	public async Task<E<CommandError>> SendVoidAsync(string command, params ICommandPart[] parameter)
		=> await SendAsync<ResponseVoid>(new TsCommand(command, parameter)).ConfigureAwait(false);

	/// <summary>
	/// Sends a TS-command.
	/// 
	/// The response (if any) is not deserialized and is discarded.
	/// </summary>
	/// <param name="command">The command name.</param>
	/// <param name="parameter">The parameters to be added to this command.
	/// See <see cref="CommandParameter"/>, <see cref="CommandOption"/> or <see cref="CommandMultiParameter"/> for more information.</param>
	/// 
	/// 
	public async Task<E<CommandError>> SendVoidAsync(TsCommand com)
		=> await SendAsync<ResponseVoid>(com).ConfigureAwait(false);

	/// <summary>
	/// Sends a TS-command.
	/// This will send a normal query-command when connected via query client. When connected as a full client the first specified notification is used as the response.
	/// 
	/// </summary>
	/// <param name="command">The command name.</param>
	/// <param name="parameter">The parameters to be added to this command.
	/// See <see cref="CommandParameter"/>, <see cref="CommandOption"/> or <see cref="CommandMultiParameter"/> for more information.</param>
	/// <param name="type">The notification type to wait for and serialize to when called from the full client.</param>
	/// 
	public async Task<R<ResponseDictionary[], CommandError>> SendHybridAsync(string command, NotificationType type, params ICommandPart[] parameter)
		=> await SendHybridAsync<ResponseDictionary>(new TsCommand(command, parameter), type).ConfigureAwait(false);

	/// <summary>
	/// Sends a TS-command.
	/// This will send a normal query-command when connected via query client. When connected as a full client the first specified notification is used as the response.
	/// 
	/// </summary>
	/// <param name="command">The command name.</param>
	/// <param name="parameter">The parameters to be added to this command.
	/// See <see cref="CommandParameter"/>, <see cref="CommandOption"/> or <see cref="CommandMultiParameter"/> for more information.</param>
	/// <param name="type">The notification type to wait for and serialize to when called from the full client.</param>
	/// <returns>Returns an enumeration of the deserialized and split up in <see cref="T"/> objects data.</returns>
	public async Task<R<T[], CommandError>> SendHybridAsync<T>(string command, NotificationType type, params ICommandPart[] parameter) where T : class, IResponse, new()
		=> await SendHybridAsync<T>(new TsCommand(command, parameter), type).ConfigureAwait(false);

	}
}