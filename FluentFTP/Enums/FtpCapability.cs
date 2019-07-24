﻿using System;

namespace FluentFTP {
	/// <summary>
	/// Server features
	/// </summary>
	[Flags]
	public enum FtpCapability : int {
		/// <summary>
		/// This server said it doesn't support anything!
		/// </summary>
		NONE = 1,

		/// <summary>
		/// Supports the MLST command
		/// </summary>
		MLSD = 2,

		/// <summary>
		/// Supports the SIZE command
		/// </summary>
		SIZE = 3,

		/// <summary>
		/// Supports the MDTM command
		/// </summary>
		MDTM = 4,

		/// <summary>
		/// Supports download/upload stream resumes
		/// </summary>
		REST = 5,

		/// <summary>
		/// Supports UTF8
		/// </summary>
		UTF8 = 6,

		/// <summary>
		/// PRET Command used in distributed ftp server software DrFTPD
		/// </summary>
		PRET = 7,

		/// <summary>
		/// Server supports the MFMT command for setting the
		/// modified date of an object on the server
		/// </summary>
		MFMT = 8,

		/// <summary>
		/// Server supports the MFCT command for setting the
		/// created date of an object on the server
		/// </summary>
		MFCT = 9,

		/// <summary>
		/// Server supports the MFF command for setting certain facts
		/// about file system objects. If you need this command, it would
		/// probably be handy to query FEAT your self and have a look at
		/// the FtpReply.InfoMessages property to see which facts the server
		/// allows you to modify.
		/// </summary>
		MFF = 10,

		/// <summary>
		/// Server supports the STAT command
		/// </summary>
		STAT = 11,

		/// <summary>
		/// Support for the HASH command
		/// </summary>
		HASH = 12,

		/// <summary>
		/// Support for the MD5 command
		/// </summary>
		MD5 = 13,

		/// <summary>
		/// Support for the XMD5 command
		/// </summary>
		XMD5 = 14,

		/// <summary>
		/// Support for the XCRC command
		/// </summary>
		XCRC = 15,

		/// <summary>
		/// Support for the XSHA1 command
		/// </summary>
		XSHA1 = 16,

		/// <summary>
		/// Support for the XSHA256 command
		/// </summary>
		XSHA256 = 17,

		/// <summary>
		/// Support for the XSHA512 command
		/// </summary>
		XSHA512 = 18,

		/// <summary>
		/// Support for the EPSV file-transfer command
		/// </summary>
		EPSV = 19,

		/// <summary>
		/// Support for the CPSV command
		/// </summary>
		CPSV = 20,

		/// <summary>
		/// Support for the NOOP command
		/// </summary>
		NOOP = 21,

		/// <summary>
		/// Support for the CLNT command
		/// </summary>
		CLNT = 22,

		/// <summary>
		/// Support for the SSCN command
		/// </summary>
		SSCN = 23,

		/// <summary>
		/// Support for the SITE MKDIR server-specific command (ProFTPd)
		/// </summary>
		SITE_MKDIR = 24,

		/// <summary>
		/// Support for the SITE RMDIR (remove directory) server-specific command (ProFTPd)
		/// </summary>
		SITE_RMDIR = 25,

		/// <summary>
		/// Support for the SITE UTIME server-specific command (ProFTPd)
		/// </summary>
		SITE_UTIME = 26,

		/// <summary>
		/// Support for the SITE SYMLINK server-specific command (ProFTPd)
		/// </summary>
		SITE_SYMLINK = 27,

		/// <summary>
		/// Support for the AVBL (get available space) server-specific command (Serv-U)
		/// </summary>
		AVBL = 28,

		/// <summary>
		/// Support for the THMB (get image thumbnail) server-specific command (Serv-U)
		/// </summary>
		THMB = 29,

		/// <summary>
		/// Support for the RMDA (remove directory) server-specific command (Serv-U)
		/// </summary>
		RMDA = 30,

		/// <summary>
		/// Support for the DSIZ (get directory size) server-specific command (Serv-U)
		/// </summary>
		DSIZ = 31,
	}
}