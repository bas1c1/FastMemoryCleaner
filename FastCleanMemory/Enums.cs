// Decompiled with JetBrains decompiler
// Type: WinMemoryCleaner.Enums
// Assembly: WinMemoryCleaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=6b2fedd337d48392
// MVID: C6DC4AE6-F35B-40BC-B03E-1A665C103BE4
// Assembly location: C:\Users\Roman\Desktop\SCleaner.exe
// XML documentation location: C:\Users\Roman\Desktop\SCleaner.xml

using System;

namespace FastCleanMemory
{
  /// <summary>Enumerators</summary>
  public static class Enums
  {
    /// <summary>Log</summary>
    public static class Log
    {
      /// <summary>Level</summary>
      [Flags]
      public enum Level
      {
        /// <summary>None</summary>
        None = 0,
        /// <summary>Debug</summary>
        Debug = 1,
        /// <summary>Information</summary>
        Info = 2,
        /// <summary>Warning</summary>
        Warning = 4,
        /// <summary>Error</summary>
        Error = 8,
      }
    }

    /// <summary>Memory</summary>
    public static class Memory
    {
      /// <summary>Area</summary>
      [Flags]
      public enum Area
      {
        /// <summary>
        /// 
        /// </summary>
        None = 0,
        /// <summary>Combined Page List</summary>
        CombinedPageList = 1,
        /// <summary>Modified Page List</summary>
        ModifiedPageList = 2,
        /// <summary>Processes Working Set</summary>
        ProcessesWorkingSet = 4,
        /// <summary>Standby List</summary>
        StandbyList = 8,
        /// <summary>Standby List (Low Priority)</summary>
        StandbyListLowPriority = 16, // 0x00000010
        /// <summary>System Working Set</summary>
        SystemWorkingSet = 32, // 0x00000020
      }
    }

    internal static class Windows
    {
      /// <summary>Windows system error codes</summary>
      /// <remarks>
      /// https://docs.microsoft.com/en-us/windows/win32/debug/system-error-codes
      /// </remarks>
      internal enum SystemErrorCode
      {
        /// <summary>The operation completed successfully.</summary>
        ERROR_SUCCESS = 0,
        /// <summary>Incorrect function.</summary>
        ERROR_INVALID_FUNCTION = 1,
        /// <summary>The system cannot find the file specified.</summary>
        ERROR_FILE_NOT_FOUND = 2,
        /// <summary>The system cannot find the path specified.</summary>
        ERROR_PATH_NOT_FOUND = 3,
        /// <summary>The system cannot open the file.</summary>
        ERROR_TOO_MANY_OPEN_FILES = 4,
        /// <summary>Access is denied.</summary>
        ERROR_ACCESS_DENIED = 5,
        /// <summary>The handle is invalid.</summary>
        ERROR_INVALID_HANDLE = 6,
        /// <summary>The storage control blocks were destroyed.</summary>
        ERROR_ARENA_TRASHED = 7,
        /// <summary>
        /// Not enough storage is available to process this command.
        /// </summary>
        ERROR_NOT_ENOUGH_MEMORY = 8,
        /// <summary>The storage control block address is invalid.</summary>
        ERROR_INVALID_BLOCK = 9,
        /// <summary>The environment is incorrect.</summary>
        ERROR_BAD_ENVIRONMENT = 10, // 0x0000000A
        /// <summary>
        /// An attempt was made to load a program with an incorrect format.
        /// </summary>
        ERROR_BAD_FORMAT = 11, // 0x0000000B
        /// <summary>The access code is invalid.</summary>
        ERROR_INVALID_ACCESS = 12, // 0x0000000C
        /// <summary>The data is invalid.</summary>
        ERROR_INVALID_DATA = 13, // 0x0000000D
        /// <summary>
        /// Not enough storage is available to complete this operation.
        /// </summary>
        ERROR_OUTOFMEMORY = 14, // 0x0000000E
        /// <summary>The system cannot find the drive specified.</summary>
        ERROR_INVALID_DRIVE = 15, // 0x0000000F
        /// <summary>The directory cannot be removed.</summary>
        ERROR_CURRENT_DIRECTORY = 16, // 0x00000010
        /// <summary>
        /// The system cannot move the file to a different disk drive.
        /// </summary>
        ERROR_NOT_SAME_DEVICE = 17, // 0x00000011
        /// <summary>There are no more files.</summary>
        ERROR_NO_MORE_FILES = 18, // 0x00000012
        /// <summary>The media is write protected.</summary>
        ERROR_WRITE_PROTECT = 19, // 0x00000013
        /// <summary>The system cannot find the device specified.</summary>
        ERROR_BAD_UNIT = 20, // 0x00000014
        /// <summary>The device is not ready.</summary>
        ERROR_NOT_READY = 21, // 0x00000015
        /// <summary>The device does not recognize the command.</summary>
        ERROR_BAD_COMMAND = 22, // 0x00000016
        /// <summary>Data error (cyclic redundancy check).</summary>
        ERROR_CRC = 23, // 0x00000017
        /// <summary>
        /// The program issued a command but the command length is incorrect.
        /// </summary>
        ERROR_BAD_LENGTH = 24, // 0x00000018
        /// <summary>
        /// The drive cannot locate a specific area or track on the disk.
        /// </summary>
        ERROR_SEEK = 25, // 0x00000019
        /// <summary>The specified disk or diskette cannot be accessed.</summary>
        ERROR_NOT_DOS_DISK = 26, // 0x0000001A
        /// <summary>The drive cannot find the sector requested.</summary>
        ERROR_SECTOR_NOT_FOUND = 27, // 0x0000001B
        /// <summary>The printer is out of paper.</summary>
        ERROR_OUT_OF_PAPER = 28, // 0x0000001C
        /// <summary>The system cannot write to the specified device.</summary>
        ERROR_WRITE_FAULT = 29, // 0x0000001D
        /// <summary>The system cannot read from the specified device.</summary>
        ERROR_READ_FAULT = 30, // 0x0000001E
        /// <summary>A device attached to the system is not functioning.</summary>
        ERROR_GEN_FAILURE = 31, // 0x0000001F
        /// <summary>
        /// The process cannot access the file because it is being used by another process.
        /// </summary>
        ERROR_SHARING_VIOLATION = 32, // 0x00000020
        /// <summary>
        /// The process cannot access the file because another process has locked a portion of the file.
        /// </summary>
        ERROR_LOCK_VIOLATION = 33, // 0x00000021
        /// <summary>
        /// The wrong diskette is in the drive. Insert %2 (Volume Serial Number: %3) into drive %1.
        /// </summary>
        ERROR_WRONG_DISK = 34, // 0x00000022
        /// <summary>Too many files opened for sharing.</summary>
        ERROR_SHARING_BUFFER_EXCEEDED = 36, // 0x00000024
        /// <summary>Reached the end of the file.</summary>
        ERROR_HANDLE_EOF = 38, // 0x00000026
        /// <summary>The disk is full.</summary>
        ERROR_HANDLE_DISK_FULL = 39, // 0x00000027
        /// <summary>The request is not supported.</summary>
        ERROR_NOT_SUPPORTED = 50, // 0x00000032
        /// <summary>
        /// Windows cannot find the network path. Verify that the network path is correct and the destination computer is not busy or turned off. If Windows still cannot find the network path, contact your network administrator.
        /// </summary>
        ERROR_REM_NOT_LIST = 51, // 0x00000033
        /// <summary>
        /// You were not connected because a duplicate name exists on the network. If joining a domain, go to System in Control Panel to change the computer name and try again. If joining a workgroup, choose another workgroup name.
        /// </summary>
        ERROR_DUP_NAME = 52, // 0x00000034
        /// <summary>The network path was not found.</summary>
        ERROR_BAD_NETPATH = 53, // 0x00000035
        /// <summary>The network is busy.</summary>
        ERROR_NETWORK_BUSY = 54, // 0x00000036
        /// <summary>
        /// The specified network resource or device is no longer available.
        /// </summary>
        ERROR_DEV_NOT_EXIST = 55, // 0x00000037
        /// <summary>The network BIOS command limit has been reached.</summary>
        ERROR_TOO_MANY_CMDS = 56, // 0x00000038
        /// <summary>A network adapter hardware error occurred.</summary>
        ERROR_ADAP_HDW_ERR = 57, // 0x00000039
        /// <summary>
        /// The specified server cannot perform the requested operation.
        /// </summary>
        ERROR_BAD_NET_RESP = 58, // 0x0000003A
        /// <summary>An unexpected network error occurred.</summary>
        ERROR_UNEXP_NET_ERR = 59, // 0x0000003B
        /// <summary>The remote adapter is not compatible.</summary>
        ERROR_BAD_REM_ADAP = 60, // 0x0000003C
        /// <summary>The printer queue is full.</summary>
        ERROR_PRINTQ_FULL = 61, // 0x0000003D
        /// <summary>
        /// Space to store the file waiting to be printed is not available on the server.
        /// </summary>
        ERROR_NO_SPOOL_SPACE = 62, // 0x0000003E
        /// <summary>Your file waiting to be printed was deleted.</summary>
        ERROR_PRINT_CANCELLED = 63, // 0x0000003F
        /// <summary>The specified network name is no longer available.</summary>
        ERROR_NETNAME_DELETED = 64, // 0x00000040
        /// <summary>Network access is denied.</summary>
        ERROR_NETWORK_ACCESS_DENIED = 65, // 0x00000041
        /// <summary>The network resource type is not correct.</summary>
        ERROR_BAD_DEV_TYPE = 66, // 0x00000042
        /// <summary>The network name cannot be found.</summary>
        ERROR_BAD_NET_NAME = 67, // 0x00000043
        /// <summary>
        /// The name limit for the local computer network adapter card was exceeded.
        /// </summary>
        ERROR_TOO_MANY_NAMES = 68, // 0x00000044
        /// <summary>The network BIOS session limit was exceeded.</summary>
        ERROR_TOO_MANY_SESS = 69, // 0x00000045
        /// <summary>
        /// The remote server has been paused or is in the process of being started.
        /// </summary>
        ERROR_SHARING_PAUSED = 70, // 0x00000046
        /// <summary>
        /// No more connections can be made to this remote computer at this time because there are already as many connections as the computer can accept.
        /// </summary>
        ERROR_REQ_NOT_ACCEP = 71, // 0x00000047
        /// <summary>The specified printer or disk device has been paused.</summary>
        ERROR_REDIR_PAUSED = 72, // 0x00000048
        /// <summary>The file exists.</summary>
        ERROR_FILE_EXISTS = 80, // 0x00000050
        /// <summary>The directory or file cannot be created.</summary>
        ERROR_CANNOT_MAKE = 82, // 0x00000052
        /// <summary>Fail on INT 24.</summary>
        ERROR_FAIL_I24 = 83, // 0x00000053
        /// <summary>Storage to process this request is not available.</summary>
        ERROR_OUT_OF_STRUCTURES = 84, // 0x00000054
        /// <summary>The local device name is already in use.</summary>
        ERROR_ALREADY_ASSIGNED = 85, // 0x00000055
        /// <summary>The specified network password is not correct.</summary>
        ERROR_INVALID_PASSWORD = 86, // 0x00000056
        /// <summary>The parameter is incorrect.</summary>
        ERROR_INVALID_PARAMETER = 87, // 0x00000057
        /// <summary>A write fault occurred on the network.</summary>
        ERROR_NET_WRITE_FAULT = 88, // 0x00000058
        /// <summary>The system cannot start another process at this time.</summary>
        ERROR_NO_PROC_SLOTS = 89, // 0x00000059
        /// <summary>Cannot create another system semaphore.</summary>
        ERROR_TOO_MANY_SEMAPHORES = 100, // 0x00000064
        /// <summary>The exclusive semaphore is owned by another process.</summary>
        ERROR_EXCL_SEM_ALREADY_OWNED = 101, // 0x00000065
        /// <summary>The semaphore is set and cannot be closed.</summary>
        ERROR_SEM_IS_SET = 102, // 0x00000066
        /// <summary>The semaphore cannot be set again.</summary>
        ERROR_TOO_MANY_SEM_REQUESTS = 103, // 0x00000067
        /// <summary>
        /// Cannot request exclusive semaphores at interrupt time.
        /// </summary>
        ERROR_INVALID_AT_INTERRUPT_TIME = 104, // 0x00000068
        /// <summary>The previous ownership of this semaphore has ended.</summary>
        ERROR_SEM_OWNER_DIED = 105, // 0x00000069
        /// <summary>Insert the diskette for drive %1.</summary>
        ERROR_SEM_USER_LIMIT = 106, // 0x0000006A
        /// <summary>
        /// The program stopped because an alternate diskette was not inserted.
        /// </summary>
        ERROR_DISK_CHANGE = 107, // 0x0000006B
        /// <summary>The disk is in use or locked by another process.</summary>
        ERROR_DRIVE_LOCKED = 108, // 0x0000006C
        /// <summary>The pipe has been ended.</summary>
        ERROR_BROKEN_PIPE = 109, // 0x0000006D
        /// <summary>The system cannot open the device or file specified.</summary>
        ERROR_OPEN_FAILED = 110, // 0x0000006E
        /// <summary>The file name is too long.</summary>
        ERROR_BUFFER_OVERFLOW = 111, // 0x0000006F
        /// <summary>There is not enough space on the disk.</summary>
        ERROR_DISK_FULL = 112, // 0x00000070
        /// <summary>No more internal file identifiers available.</summary>
        ERROR_NO_MORE_SEARCH_HANDLES = 113, // 0x00000071
        /// <summary>The target internal file identifier is incorrect.</summary>
        ERROR_INVALID_TARGET_HANDLE = 114, // 0x00000072
        /// <summary>
        /// The IOCTL call made by the application program is not correct.
        /// </summary>
        ERROR_INVALID_CATEGORY = 117, // 0x00000075
        /// <summary>
        /// The verify-on-write switch parameter value is not correct.
        /// </summary>
        ERROR_INVALID_VERIFY_SWITCH = 118, // 0x00000076
        /// <summary>The system does not support the command requested.</summary>
        ERROR_BAD_DRIVER_LEVEL = 119, // 0x00000077
        /// <summary>This function is not supported on this system.</summary>
        ERROR_CALL_NOT_IMPLEMENTED = 120, // 0x00000078
        /// <summary>The semaphore timeout period has expired.</summary>
        ERROR_SEM_TIMEOUT = 121, // 0x00000079
        /// <summary>The data area passed to a system call is too small.</summary>
        ERROR_INSUFFICIENT_BUFFER = 122, // 0x0000007A
        /// <summary>
        /// The filename, directory name, or volume label syntax is incorrect.
        /// </summary>
        ERROR_INVALID_NAME = 123, // 0x0000007B
        /// <summary>The system call level is not correct.</summary>
        ERROR_INVALID_LEVEL = 124, // 0x0000007C
        /// <summary>The disk has no volume label.</summary>
        ERROR_NO_VOLUME_LABEL = 125, // 0x0000007D
        /// <summary>The specified module could not be found.</summary>
        ERROR_MOD_NOT_FOUND = 126, // 0x0000007E
        /// <summary>The specified procedure could not be found.</summary>
        ERROR_PROC_NOT_FOUND = 127, // 0x0000007F
        /// <summary>There are no child processes to wait for.</summary>
        ERROR_WAIT_NO_CHILDREN = 128, // 0x00000080
        /// <summary>The %1 application cannot be run in Win32 mode.</summary>
        ERROR_CHILD_NOT_COMPLETE = 129, // 0x00000081
        /// <summary>
        /// Attempt to use a file handle to an open disk partition for an operation other than raw disk I/O.
        /// </summary>
        ERROR_DIRECT_ACCESS_HANDLE = 130, // 0x00000082
        /// <summary>
        /// An attempt was made to move the file pointer before the beginning of the file.
        /// </summary>
        ERROR_NEGATIVE_SEEK = 131, // 0x00000083
        /// <summary>
        /// The file pointer cannot be set on the specified device or file.
        /// </summary>
        ERROR_SEEK_ON_DEVICE = 132, // 0x00000084
        /// <summary>
        /// A JOIN or SUBST command cannot be used for a drive that contains previously joined drives.
        /// </summary>
        ERROR_IS_JOIN_TARGET = 133, // 0x00000085
        /// <summary>
        /// An attempt was made to use a JOIN or SUBST command on a drive that has already been joined.
        /// </summary>
        ERROR_IS_JOINED = 134, // 0x00000086
        /// <summary>
        /// An attempt was made to use a JOIN or SUBST command on a drive that has already been substituted.
        /// </summary>
        ERROR_IS_SUBSTED = 135, // 0x00000087
        /// <summary>
        /// The system tried to delete the JOIN of a drive that is not joined.
        /// </summary>
        ERROR_NOT_JOINED = 136, // 0x00000088
        /// <summary>
        /// The system tried to delete the substitution of a drive that is not substituted.
        /// </summary>
        ERROR_NOT_SUBSTED = 137, // 0x00000089
        /// <summary>
        /// The system tried to join a drive to a directory on a joined drive.
        /// </summary>
        ERROR_JOIN_TO_JOIN = 138, // 0x0000008A
        /// <summary>
        /// The system tried to substitute a drive to a directory on a substituted drive.
        /// </summary>
        ERROR_SUBST_TO_SUBST = 139, // 0x0000008B
        /// <summary>
        /// The system tried to join a drive to a directory on a substituted drive.
        /// </summary>
        ERROR_JOIN_TO_SUBST = 140, // 0x0000008C
        /// <summary>
        /// The system tried to SUBST a drive to a directory on a joined drive.
        /// </summary>
        ERROR_SUBST_TO_JOIN = 141, // 0x0000008D
        /// <summary>
        /// The system cannot perform a JOIN or SUBST at this time.
        /// </summary>
        ERROR_BUSY_DRIVE = 142, // 0x0000008E
        /// <summary>
        /// The system cannot join or substitute a drive to or for a directory on the same drive.
        /// </summary>
        ERROR_SAME_DRIVE = 143, // 0x0000008F
        /// <summary>
        /// The directory is not a subdirectory of the root directory.
        /// </summary>
        ERROR_DIR_NOT_ROOT = 144, // 0x00000090
        /// <summary>The directory is not empty.</summary>
        ERROR_DIR_NOT_EMPTY = 145, // 0x00000091
        /// <summary>The path specified is being used in a substitute.</summary>
        ERROR_IS_SUBST_PATH = 146, // 0x00000092
        /// <summary>
        /// Not enough resources are available to process this command.
        /// </summary>
        ERROR_IS_JOIN_PATH = 147, // 0x00000093
        /// <summary>The path specified cannot be used at this time.</summary>
        ERROR_PATH_BUSY = 148, // 0x00000094
        /// <summary>
        /// An attempt was made to join or substitute a drive for which a directory on the drive is the target of a previous substitute.
        /// </summary>
        ERROR_IS_SUBST_TARGET = 149, // 0x00000095
        /// <summary>
        /// System trace information was not specified in your CONFIG.SYS file, or tracing is disallowed.
        /// </summary>
        ERROR_SYSTEM_TRACE = 150, // 0x00000096
        /// <summary>
        /// The number of specified semaphore events for DosMuxSemWait is not correct.
        /// </summary>
        ERROR_INVALID_EVENT_COUNT = 151, // 0x00000097
        /// <summary>
        /// DosMuxSemWait did not execute; too many semaphores are already set.
        /// </summary>
        ERROR_TOO_MANY_MUXWAITERS = 152, // 0x00000098
        /// <summary>The DosMuxSemWait list is not correct.</summary>
        ERROR_INVALID_LIST_FORMAT = 153, // 0x00000099
        /// <summary>
        /// The volume label you entered exceeds the label character limit of the target file system.
        /// </summary>
        ERROR_LABEL_TOO_LONG = 154, // 0x0000009A
        /// <summary>Cannot create another thread.</summary>
        ERROR_TOO_MANY_TCBS = 155, // 0x0000009B
        /// <summary>The recipient process has refused the signal.</summary>
        ERROR_SIGNAL_REFUSED = 156, // 0x0000009C
        /// <summary>
        /// The segment is already discarded and cannot be locked.
        /// </summary>
        ERROR_DISCARDED = 157, // 0x0000009D
        /// <summary>The segment is already unlocked.</summary>
        ERROR_NOT_LOCKED = 158, // 0x0000009E
        /// <summary>The address for the thread ID is not correct.</summary>
        ERROR_BAD_THREADID_ADDR = 159, // 0x0000009F
        /// <summary>One or more arguments are not correct.</summary>
        ERROR_BAD_ARGUMENTS = 160, // 0x000000A0
        /// <summary>The specified path is invalid.</summary>
        ERROR_BAD_PATHNAME = 161, // 0x000000A1
        /// <summary>A signal is already pending.</summary>
        ERROR_SIGNAL_PENDING = 162, // 0x000000A2
        /// <summary>No more threads can be created in the system.</summary>
        ERROR_MAX_THRDS_REACHED = 164, // 0x000000A4
        /// <summary>Unable to lock a region of a file.</summary>
        ERROR_LOCK_FAILED = 167, // 0x000000A7
        /// <summary>The requested resource is in use.</summary>
        ERROR_BUSY = 170, // 0x000000AA
        /// <summary>Device's command support detection is in progress.</summary>
        ERROR_DEVICE_SUPPORT_IN_PROGRESS = 171, // 0x000000AB
        /// <summary>
        /// A lock request was not outstanding for the supplied cancel region.
        /// </summary>
        ERROR_CANCEL_VIOLATION = 173, // 0x000000AD
        /// <summary>
        /// The file system does not support atomic changes to the lock type.
        /// </summary>
        ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 174, // 0x000000AE
        /// <summary>
        /// The system detected a segment number that was not correct.
        /// </summary>
        ERROR_INVALID_SEGMENT_NUMBER = 180, // 0x000000B4
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INVALID_ORDINAL = 182, // 0x000000B6
        /// <summary>Cannot create a file when that file already exists.</summary>
        ERROR_ALREADY_EXISTS = 183, // 0x000000B7
        /// <summary>The flag passed is not correct.</summary>
        ERROR_INVALID_FLAG_NUMBER = 186, // 0x000000BA
        /// <summary>The specified system semaphore name was not found.</summary>
        ERROR_SEM_NOT_FOUND = 187, // 0x000000BB
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INVALID_STARTING_CODESEG = 188, // 0x000000BC
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INVALID_STACKSEG = 189, // 0x000000BD
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INVALID_MODULETYPE = 190, // 0x000000BE
        /// <summary>Cannot run %1 in Win32 mode.</summary>
        ERROR_INVALID_EXE_SIGNATURE = 191, // 0x000000BF
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_EXE_MARKED_INVALID = 192, // 0x000000C0
        /// <summary>%1 is not a valid Win32 application.</summary>
        ERROR_BAD_EXE_FORMAT = 193, // 0x000000C1
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_ITERATED_DATA_EXCEEDS_64k = 194, // 0x000000C2
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INVALID_MINALLOCSIZE = 195, // 0x000000C3
        /// <summary>
        /// The operating system cannot run this application program.
        /// </summary>
        ERROR_DYNLINK_FROM_INVALID_RING = 196, // 0x000000C4
        /// <summary>
        /// The operating system is not presently configured to run this application.
        /// </summary>
        ERROR_IOPL_NOT_ENABLED = 197, // 0x000000C5
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INVALID_SEGDPL = 198, // 0x000000C6
        /// <summary>
        /// The operating system cannot run this application program.
        /// </summary>
        ERROR_AUTODATASEG_EXCEEDS_64k = 199, // 0x000000C7
        /// <summary>
        /// The code segment cannot be greater than or equal to 64K.
        /// </summary>
        ERROR_RING2SEG_MUST_BE_MOVABLE = 200, // 0x000000C8
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 201, // 0x000000C9
        /// <summary>The operating system cannot run %1.</summary>
        ERROR_INFLOOP_IN_RELOC_CHAIN = 202, // 0x000000CA
        /// <summary>
        /// The system could not find the environment option that was entered.
        /// </summary>
        ERROR_ENVVAR_NOT_FOUND = 203, // 0x000000CB
        /// <summary>
        /// No process in the command subtree has a signal handler.
        /// </summary>
        ERROR_NO_SIGNAL_SENT = 205, // 0x000000CD
        /// <summary>The filename or extension is too long.</summary>
        ERROR_FILENAME_EXCED_RANGE = 206, // 0x000000CE
        /// <summary>The ring 2 stack is in use.</summary>
        ERROR_RING2_STACK_IN_USE = 207, // 0x000000CF
        /// <summary>
        /// The global filename characters, * or ?, are entered incorrectly or too many global filename characters are specified.
        /// </summary>
        ERROR_META_EXPANSION_TOO_LONG = 208, // 0x000000D0
        /// <summary>The signal being posted is not correct.</summary>
        ERROR_INVALID_SIGNAL_NUMBER = 209, // 0x000000D1
        /// <summary>The signal handler cannot be set.</summary>
        ERROR_THREAD_1_INACTIVE = 210, // 0x000000D2
        /// <summary>The segment is locked and cannot be reallocated.</summary>
        ERROR_LOCKED = 212, // 0x000000D4
        /// <summary>
        /// Too many dynamic-link modules are attached to this program or dynamic-link module.
        /// </summary>
        ERROR_TOO_MANY_MODULES = 214, // 0x000000D6
        /// <summary>Cannot nest calls to LoadModule.</summary>
        ERROR_NESTING_NOT_ALLOWED = 215, // 0x000000D7
        /// <summary>
        /// This version of %1 is not compatible with the version of Windows you're running. Check your computer's system information and then contact the software publisher.
        /// </summary>
        ERROR_EXE_MACHINE_TYPE_MISMATCH = 216, // 0x000000D8
        /// <summary>The image file %1 is signed, unable to modify.</summary>
        ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY = 217, // 0x000000D9
        /// <summary>The image file %1 is strong signed, unable to modify.</summary>
        ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY = 218, // 0x000000DA
        /// <summary>
        /// This file is checked out or locked for editing by another user.
        /// </summary>
        ERROR_FILE_CHECKED_OUT = 220, // 0x000000DC
        /// <summary>The file must be checked out before saving changes.</summary>
        ERROR_CHECKOUT_REQUIRED = 221, // 0x000000DD
        /// <summary>
        /// The file type being saved or retrieved has been blocked.
        /// </summary>
        ERROR_BAD_FILE_TYPE = 222, // 0x000000DE
        /// <summary>
        /// The file size exceeds the limit allowed and cannot be saved.
        /// </summary>
        ERROR_FILE_TOO_LARGE = 223, // 0x000000DF
        /// <summary>
        /// Access Denied. Before opening files in this location, you must first add the web site to your trusted sites list, browse to the web site, and select the option to login automatically.
        /// </summary>
        ERROR_FORMS_AUTH_REQUIRED = 224, // 0x000000E0
        /// <summary>
        /// Operation did not complete successfully because the file contains a virus or potentially unwanted software.
        /// </summary>
        ERROR_VIRUS_INFECTED = 225, // 0x000000E1
        /// <summary>
        /// This file contains a virus or potentially unwanted software and cannot be opened. Due to the nature of this virus or potentially unwanted software, the file has been removed from this location.
        /// </summary>
        ERROR_VIRUS_DELETED = 226, // 0x000000E2
        /// <summary>The pipe is local.</summary>
        ERROR_PIPE_LOCAL = 229, // 0x000000E5
        /// <summary>The pipe state is invalid.</summary>
        ERROR_BAD_PIPE = 230, // 0x000000E6
        /// <summary>All pipe instances are busy.</summary>
        ERROR_PIPE_BUSY = 231, // 0x000000E7
        /// <summary>The pipe is being closed.</summary>
        ERROR_NO_DATA = 232, // 0x000000E8
        /// <summary>No process is on the other end of the pipe.</summary>
        ERROR_PIPE_NOT_CONNECTED = 233, // 0x000000E9
        /// <summary>More data is available.</summary>
        ERROR_MORE_DATA = 234, // 0x000000EA
        /// <summary>The session was canceled.</summary>
        ERROR_VC_DISCONNECTED = 240, // 0x000000F0
        /// <summary>The specified extended attribute name was invalid.</summary>
        ERROR_INVALID_EA_NAME = 254, // 0x000000FE
        /// <summary>The extended attributes are inconsistent.</summary>
        ERROR_EA_LIST_INCONSISTENT = 255, // 0x000000FF
        /// <summary>The wait operation timed out.</summary>
        WAIT_TIMEOUT = 258, // 0x00000102
        /// <summary>No more data is available.</summary>
        ERROR_NO_MORE_ITEMS = 259, // 0x00000103
        /// <summary>The copy functions cannot be used.</summary>
        ERROR_CANNOT_COPY = 266, // 0x0000010A
        /// <summary>The directory name is invalid.</summary>
        ERROR_DIRECTORY = 267, // 0x0000010B
        /// <summary>The extended attributes did not fit in the buffer.</summary>
        ERROR_EAS_DIDNT_FIT = 275, // 0x00000113
        /// <summary>
        /// The extended attribute file on the mounted file system is corrupt.
        /// </summary>
        ERROR_EA_FILE_CORRUPT = 276, // 0x00000114
        /// <summary>The extended attribute table file is full.</summary>
        ERROR_EA_TABLE_FULL = 277, // 0x00000115
        /// <summary>The specified extended attribute handle is invalid.</summary>
        ERROR_INVALID_EA_HANDLE = 278, // 0x00000116
        /// <summary>
        /// The mounted file system does not support extended attributes.
        /// </summary>
        ERROR_EAS_NOT_SUPPORTED = 282, // 0x0000011A
        /// <summary>Attempt to release mutex not owned by caller.</summary>
        ERROR_NOT_OWNER = 288, // 0x00000120
        /// <summary>Too many posts were made to a semaphore.</summary>
        ERROR_TOO_MANY_POSTS = 298, // 0x0000012A
        /// <summary>
        /// Only part of a ReadProcessMemory or WriteProcessMemory request was completed.
        /// </summary>
        ERROR_PARTIAL_COPY = 299, // 0x0000012B
        /// <summary>The oplock request is denied.</summary>
        ERROR_OPLOCK_NOT_GRANTED = 300, // 0x0000012C
        /// <summary>
        /// An invalid oplock acknowledgment was received by the system.
        /// </summary>
        ERROR_INVALID_OPLOCK_PROTOCOL = 301, // 0x0000012D
        /// <summary>
        /// The volume is too fragmented to complete this operation.
        /// </summary>
        ERROR_DISK_TOO_FRAGMENTED = 302, // 0x0000012E
        /// <summary>
        /// The file cannot be opened because it is in the process of being deleted.
        /// </summary>
        ERROR_DELETE_PENDING = 303, // 0x0000012F
        /// <summary>
        /// Short name settings may not be changed on this volume due to the global registry setting.
        /// </summary>
        ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING = 304, // 0x00000130
        /// <summary>Short names are not enabled on this volume.</summary>
        ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME = 305, // 0x00000131
        /// <summary>
        /// The security stream for the given volume is in an inconsistent state. Please run CHKDSK on the volume.
        /// </summary>
        ERROR_SECURITY_STREAM_IS_INCONSISTENT = 306, // 0x00000132
        /// <summary>
        /// A requested file lock operation cannot be processed due to an invalid byte range.
        /// </summary>
        ERROR_INVALID_LOCK_RANGE = 307, // 0x00000133
        /// <summary>
        /// The subsystem needed to support the image type is not present.
        /// </summary>
        ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT = 308, // 0x00000134
        /// <summary>
        /// The specified file already has a notification GUID associated with it.
        /// </summary>
        ERROR_NOTIFICATION_GUID_ALREADY_DEFINED = 309, // 0x00000135
        /// <summary>
        /// An invalid exception handler routine has been detected.
        /// </summary>
        ERROR_INVALID_EXCEPTION_HANDLER = 310, // 0x00000136
        /// <summary>Duplicate privileges were specified for the token.</summary>
        ERROR_DUPLICATE_PRIVILEGES = 311, // 0x00000137
        /// <summary>
        /// No ranges for the specified operation were able to be processed.
        /// </summary>
        ERROR_NO_RANGES_PROCESSED = 312, // 0x00000138
        /// <summary>
        /// Operation is not allowed on a file system internal file.
        /// </summary>
        ERROR_NOT_ALLOWED_ON_SYSTEM_FILE = 313, // 0x00000139
        /// <summary>
        /// The physical resources of this disk have been exhausted.
        /// </summary>
        ERROR_DISK_RESOURCES_EXHAUSTED = 314, // 0x0000013A
        /// <summary>The token representing the data is invalid.</summary>
        ERROR_INVALID_TOKEN = 315, // 0x0000013B
        /// <summary>The device does not support the command feature.</summary>
        ERROR_DEVICE_FEATURE_NOT_SUPPORTED = 316, // 0x0000013C
        /// <summary>
        /// The system cannot find message text for message number 0x%1 in the message file for %2.
        /// </summary>
        ERROR_MR_MID_NOT_FOUND = 317, // 0x0000013D
        /// <summary>The scope specified was not found.</summary>
        ERROR_SCOPE_NOT_FOUND = 318, // 0x0000013E
        /// <summary>
        /// The Central Access Policy specified is not defined on the target machine.
        /// </summary>
        ERROR_UNDEFINED_SCOPE = 319, // 0x0000013F
        /// <summary>
        /// The Central Access Policy obtained from Active Directory is invalid.
        /// </summary>
        ERROR_INVALID_CAP = 320, // 0x00000140
        /// <summary>The device is unreachable.</summary>
        ERROR_DEVICE_UNREACHABLE = 321, // 0x00000141
        /// <summary>
        /// The target device has insufficient resources to complete the operation.
        /// </summary>
        ERROR_DEVICE_NO_RESOURCES = 322, // 0x00000142
        /// <summary>
        /// A data integrity checksum error occurred. Data in the file stream is corrupt.
        /// </summary>
        ERROR_DATA_CHECKSUM_ERROR = 323, // 0x00000143
        /// <summary>
        /// An attempt was made to modify both a KERNEL and normal Extended Attribute (EA) in the same operation.
        /// </summary>
        ERROR_INTERMIXED_KERNEL_EA_OPERATION = 324, // 0x00000144
        /// <summary>Device does not support file-level TRIM.</summary>
        ERROR_FILE_LEVEL_TRIM_NOT_SUPPORTED = 326, // 0x00000146
        /// <summary>
        /// The command specified a data offset that does not align to the device's granularity/alignment.
        /// </summary>
        ERROR_OFFSET_ALIGNMENT_VIOLATION = 327, // 0x00000147
        /// <summary>
        /// The command specified an invalid field in its parameter list.
        /// </summary>
        ERROR_INVALID_FIELD_IN_PARAMETER_LIST = 328, // 0x00000148
        /// <summary>
        /// An operation is currently in progress with the device.
        /// </summary>
        ERROR_OPERATION_IN_PROGRESS = 329, // 0x00000149
        /// <summary>
        /// An attempt was made to send down the command via an invalid path to the target device.
        /// </summary>
        ERROR_BAD_DEVICE_PATH = 330, // 0x0000014A
        /// <summary>
        /// The command specified a number of descriptors that exceeded the maximum supported by the device.
        /// </summary>
        ERROR_TOO_MANY_DESCRIPTORS = 331, // 0x0000014B
        /// <summary>Scrub is disabled on the specified file.</summary>
        ERROR_SCRUB_DATA_DISABLED = 332, // 0x0000014C
        /// <summary>The storage device does not provide redundancy.</summary>
        ERROR_NOT_REDUNDANT_STORAGE = 333, // 0x0000014D
        /// <summary>An operation is not supported on a resident file.</summary>
        ERROR_RESIDENT_FILE_NOT_SUPPORTED = 334, // 0x0000014E
        /// <summary>An operation is not supported on a compressed file.</summary>
        ERROR_COMPRESSED_FILE_NOT_SUPPORTED = 335, // 0x0000014F
        /// <summary>An operation is not supported on a directory.</summary>
        ERROR_DIRECTORY_NOT_SUPPORTED = 336, // 0x00000150
        /// <summary>
        /// The specified copy of the requested data could not be read.
        /// </summary>
        ERROR_NOT_READ_FROM_COPY = 337, // 0x00000151
        /// <summary>No action was taken as a system reboot is required.</summary>
        ERROR_FAIL_NOACTION_REBOOT = 350, // 0x0000015E
        /// <summary>The shutdown operation failed.</summary>
        ERROR_FAIL_SHUTDOWN = 351, // 0x0000015F
        /// <summary>The restart operation failed.</summary>
        ERROR_FAIL_RESTART = 352, // 0x00000160
        /// <summary>The maximum number of sessions has been reached.</summary>
        ERROR_MAX_SESSIONS_REACHED = 353, // 0x00000161
        /// <summary>The thread is already in background processing mode.</summary>
        ERROR_THREAD_MODE_ALREADY_BACKGROUND = 400, // 0x00000190
        /// <summary>The thread is not in background processing mode.</summary>
        ERROR_THREAD_MODE_NOT_BACKGROUND = 401, // 0x00000191
        /// <summary>The process is already in background processing mode.</summary>
        ERROR_PROCESS_MODE_ALREADY_BACKGROUND = 402, // 0x00000192
        /// <summary>The process is not in background processing mode.</summary>
        ERROR_PROCESS_MODE_NOT_BACKGROUND = 403, // 0x00000193
        /// <summary>Attempt to access invalid address.</summary>
        ERROR_INVALID_ADDRESS = 487, // 0x000001E7
        /// <summary>User profile cannot be loaded.</summary>
        ERROR_USER_PROFILE_LOAD = 500, // 0x000001F4
        /// <summary>Arithmetic result exceeded 32 bits.</summary>
        ERROR_ARITHMETIC_OVERFLOW = 534, // 0x00000216
        /// <summary>There is a process on other end of the pipe.</summary>
        ERROR_PIPE_CONNECTED = 535, // 0x00000217
        /// <summary>
        /// Waiting for a process to open the other end of the pipe.
        /// </summary>
        ERROR_PIPE_LISTENING = 536, // 0x00000218
        /// <summary>
        /// Application verifier has found an error in the current process.
        /// </summary>
        ERROR_VERIFIER_STOP = 537, // 0x00000219
        /// <summary>An error occurred in the ABIOS subsystem.</summary>
        ERROR_ABIOS_ERROR = 538, // 0x0000021A
        /// <summary>A warning occurred in the WX86 subsystem.</summary>
        ERROR_WX86_WARNING = 539, // 0x0000021B
        /// <summary>An error occurred in the WX86 subsystem.</summary>
        ERROR_WX86_ERROR = 540, // 0x0000021C
        /// <summary>
        /// An attempt was made to cancel or set a timer that has an associated APC and the subject thread is not the thread that originally set the timer with an associated APC routine.
        /// </summary>
        ERROR_TIMER_NOT_CANCELED = 541, // 0x0000021D
        /// <summary>Unwind exception code.</summary>
        ERROR_UNWIND = 542, // 0x0000021E
        /// <summary>
        /// An invalid or unaligned stack was encountered during an unwind operation.
        /// </summary>
        ERROR_BAD_STACK = 543, // 0x0000021F
        /// <summary>
        /// An invalid unwind target was encountered during an unwind operation.
        /// </summary>
        ERROR_INVALID_UNWIND_TARGET = 544, // 0x00000220
        /// <summary>
        /// Invalid Object Attributes specified to NtCreatePort or invalid Port Attributes specified to NtConnectPort
        /// </summary>
        ERROR_INVALID_PORT_ATTRIBUTES = 545, // 0x00000221
        /// <summary>
        /// Length of message passed to NtRequestPort or NtRequestWaitReplyPort was longer than the maximum message allowed by the port.
        /// </summary>
        ERROR_PORT_MESSAGE_TOO_LONG = 546, // 0x00000222
        /// <summary>
        /// An attempt was made to lower a quota limit below the current usage.
        /// </summary>
        ERROR_INVALID_QUOTA_LOWER = 547, // 0x00000223
        /// <summary>
        /// An attempt was made to attach to a device that was already attached to another device.
        /// </summary>
        ERROR_DEVICE_ALREADY_ATTACHED = 548, // 0x00000224
        /// <summary>
        /// An attempt was made to execute an instruction at an unaligned address and the host system does not support unaligned instruction references.
        /// </summary>
        ERROR_INSTRUCTION_MISALIGNMENT = 549, // 0x00000225
        /// <summary>Profiling not started.</summary>
        ERROR_PROFILING_NOT_STARTED = 550, // 0x00000226
        /// <summary>Profiling not stopped.</summary>
        ERROR_PROFILING_NOT_STOPPED = 551, // 0x00000227
        /// <summary>
        /// The passed ACL did not contain the minimum required information.
        /// </summary>
        ERROR_COULD_NOT_INTERPRET = 552, // 0x00000228
        /// <summary>
        /// The number of active profiling objects is at the maximum and no more may be started.
        /// </summary>
        ERROR_PROFILING_AT_LIMIT = 553, // 0x00000229
        /// <summary>
        /// Used to indicate that an operation cannot continue without blocking for I/O.
        /// </summary>
        ERROR_CANT_WAIT = 554, // 0x0000022A
        /// <summary>
        /// Indicates that a thread attempted to terminate itself by default (called NtTerminateThread with NULL) and it was the last thread in the current process.
        /// </summary>
        ERROR_CANT_TERMINATE_SELF = 555, // 0x0000022B
        /// <summary>
        /// If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.
        /// </summary>
        ERROR_UNEXPECTED_MM_CREATE_ERR = 556, // 0x0000022C
        /// <summary>
        /// If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.
        /// </summary>
        ERROR_UNEXPECTED_MM_MAP_ERROR = 557, // 0x0000022D
        /// <summary>
        /// If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.
        /// </summary>
        ERROR_UNEXPECTED_MM_EXTEND_ERR = 558, // 0x0000022E
        /// <summary>
        /// A malformed function table was encountered during an unwind operation.
        /// </summary>
        ERROR_BAD_FUNCTION_TABLE = 559, // 0x0000022F
        /// <summary>
        /// Indicates that an attempt was made to assign protection to a file system file or directory and one of the SIDs in the security descriptor could not be translated into a GUID that could be stored by the file system. This causes the protection attempt to fail, which may cause a file creation attempt to fail.
        /// </summary>
        ERROR_NO_GUID_TRANSLATION = 560, // 0x00000230
        /// <summary>
        /// Indicates that an attempt was made to grow an LDT by setting its size, or that the size was not an even number of selectors.
        /// </summary>
        ERROR_INVALID_LDT_SIZE = 561, // 0x00000231
        /// <summary>
        /// Indicates that the starting value for the LDT information was not an integral multiple of the selector size.
        /// </summary>
        ERROR_INVALID_LDT_OFFSET = 563, // 0x00000233
        /// <summary>
        /// Indicates that the user supplied an invalid descriptor when trying to set up Ldt descriptors.
        /// </summary>
        ERROR_INVALID_LDT_DESCRIPTOR = 564, // 0x00000234
        /// <summary>
        /// Indicates a process has too many threads to perform the requested action. For example, assignment of a primary token may only be performed when a process has zero or one threads.
        /// </summary>
        ERROR_TOO_MANY_THREADS = 565, // 0x00000235
        /// <summary>
        /// An attempt was made to operate on a thread within a specific process, but the thread specified is not in the process specified.
        /// </summary>
        ERROR_THREAD_NOT_IN_PROCESS = 566, // 0x00000236
        /// <summary>Page file quota was exceeded.</summary>
        ERROR_PAGEFILE_QUOTA_EXCEEDED = 567, // 0x00000237
        /// <summary>
        /// The Netlogon service cannot start because another Netlogon service running in the domain conflicts with the specified role.
        /// </summary>
        ERROR_LOGON_SERVER_CONFLICT = 568, // 0x00000238
        /// <summary>
        /// The SAM database on a Windows Server is significantly out of synchronization with the copy on the Domain Controller. A complete synchronization is required.
        /// </summary>
        ERROR_SYNCHRONIZATION_REQUIRED = 569, // 0x00000239
        /// <summary>
        /// The NtCreateFile API failed. This error should never be returned to an application, it is a place holder for the Windows Lan Manager Redirector to use in its internal error mapping routines.
        /// </summary>
        ERROR_NET_OPEN_FAILED = 570, // 0x0000023A
        /// <summary>
        /// {Privilege Failed} The I/O permissions for the process could not be changed.
        /// </summary>
        ERROR_IO_PRIVILEGE_FAILED = 571, // 0x0000023B
        /// <summary>
        /// {Application Exit by CTRL+C} The application terminated as a result of a CTRL+C.
        /// </summary>
        ERROR_CONTROL_C_EXIT = 572, // 0x0000023C
        /// <summary>
        /// {Missing System File} The required system file %hs is bad or missing.
        /// </summary>
        ERROR_MISSING_SYSTEMFILE = 573, // 0x0000023D
        /// <summary>
        /// {Application Error} The exception %s (0x%08lx) occurred in the application at location 0x%08lx.
        /// </summary>
        ERROR_UNHANDLED_EXCEPTION = 574, // 0x0000023E
        /// <summary>
        /// {Application Error} The application was unable to start correctly (0x%lx). Click OK to close the application.
        /// </summary>
        ERROR_APP_INIT_FAILURE = 575, // 0x0000023F
        /// <summary>
        /// {Unable to Create Paging File} The creation of the paging file %hs failed (%lx). The requested size was %ld.
        /// </summary>
        ERROR_PAGEFILE_CREATE_FAILED = 576, // 0x00000240
        /// <summary>
        /// Windows cannot verify the digital signature for this file. A recent hardware or software change might have installed a file that is signed incorrectly or damaged, or that might be malicious software from an unknown source.
        /// </summary>
        ERROR_INVALID_IMAGE_HASH = 577, // 0x00000241
        /// <summary>
        /// {No Paging File Specified} No paging file was specified in the system configuration.
        /// </summary>
        ERROR_NO_PAGEFILE = 578, // 0x00000242
        /// <summary>
        /// {EXCEPTION} A real-mode application issued a floating-point instruction and floating-point hardware is not present.
        /// </summary>
        ERROR_ILLEGAL_FLOAT_CONTEXT = 579, // 0x00000243
        /// <summary>
        /// An event pair synchronization operation was performed using the thread specific client/server event pair object, but no event pair object was associated with the thread.
        /// </summary>
        ERROR_NO_EVENT_PAIR = 580, // 0x00000244
        /// <summary>A Windows Server has an incorrect configuration.</summary>
        ERROR_DOMAIN_CTRLR_CONFIG_ERROR = 581, // 0x00000245
        /// <summary>
        /// An illegal character was encountered. For a multi-byte character set this includes a lead byte without a succeeding trail byte. For the Unicode character set this includes the characters 0xFFFF and 0xFFFE.
        /// </summary>
        ERROR_ILLEGAL_CHARACTER = 582, // 0x00000246
        /// <summary>
        /// The Unicode character is not defined in the Unicode character set installed on the system.
        /// </summary>
        ERROR_UNDEFINED_CHARACTER = 583, // 0x00000247
        /// <summary>
        /// The paging file cannot be created on a floppy diskette.
        /// </summary>
        ERROR_FLOPPY_VOLUME = 584, // 0x00000248
        /// <summary>
        /// The system BIOS failed to connect a system interrupt to the device or bus for which the device is connected.
        /// </summary>
        ERROR_BIOS_FAILED_TO_CONNECT_INTERRUPT = 585, // 0x00000249
        /// <summary>
        /// This operation is only allowed for the Primary Domain Controller of the domain.
        /// </summary>
        ERROR_BACKUP_CONTROLLER = 586, // 0x0000024A
        /// <summary>
        /// An attempt was made to acquire a mutant such that its maximum count would have been exceeded.
        /// </summary>
        ERROR_MUTANT_LIMIT_EXCEEDED = 587, // 0x0000024B
        /// <summary>
        /// A volume has been accessed for which a file system driver is required that has not yet been loaded.
        /// </summary>
        ERROR_FS_DRIVER_REQUIRED = 588, // 0x0000024C
        /// <summary>
        /// {Registry File Failure} The registry cannot load the hive (file): %hs or its log or alternate. It is corrupt, absent, or not writable.
        /// </summary>
        ERROR_CANNOT_LOAD_REGISTRY_FILE = 589, // 0x0000024D
        /// <summary>
        /// {Unexpected Failure in DebugActiveProcess} An unexpected failure occurred while processing a DebugActiveProcess API request. You may choose OK to terminate the process, or Cancel to ignore the error.
        /// </summary>
        ERROR_DEBUG_ATTACH_FAILED = 590, // 0x0000024E
        /// <summary>
        /// {Fatal System Error} The %hs system process terminated unexpectedly with a status of 0x%08x (0x%08x 0x%08x). The system has been shut down.
        /// </summary>
        ERROR_SYSTEM_PROCESS_TERMINATED = 591, // 0x0000024F
        /// <summary>
        /// {Data Not Accepted} The TDI client could not handle the data received during an indication.
        /// </summary>
        ERROR_DATA_NOT_ACCEPTED = 592, // 0x00000250
        /// <summary>NTVDM encountered a hard error.</summary>
        ERROR_VDM_HARD_ERROR = 593, // 0x00000251
        /// <summary>
        /// {Cancel Timeout} The driver %hs failed to complete a cancelled I/O request in the allotted time.
        /// </summary>
        ERROR_DRIVER_CANCEL_TIMEOUT = 594, // 0x00000252
        /// <summary>
        /// {Reply Message Mismatch} An attempt was made to reply to an LPC message, but the thread specified by the client ID in the message was not waiting on that message.
        /// </summary>
        ERROR_REPLY_MESSAGE_MISMATCH = 595, // 0x00000253
        /// <summary>
        /// {Delayed Write Failed} Windows was unable to save all the data for the file %hs. The data has been lost. This error may be caused by a failure of your computer hardware or network connection. Please try to save this file elsewhere.
        /// </summary>
        ERROR_LOST_WRITEBEHIND_DATA = 596, // 0x00000254
        /// <summary>
        /// The parameter(s) passed to the server in the client/server shared memory window were invalid. Too much data may have been put in the shared memory window.
        /// </summary>
        ERROR_CLIENT_SERVER_PARAMETERS_INVALID = 597, // 0x00000255
        /// <summary>The stream is not a tiny stream.</summary>
        ERROR_NOT_TINY_STREAM = 598, // 0x00000256
        /// <summary>
        /// The request must be handled by the stack overflow code.
        /// </summary>
        ERROR_STACK_OVERFLOW_READ = 599, // 0x00000257
        /// <summary>
        /// Internal OFS status codes indicating how an allocation operation is handled. Either it is retried after the containing onode is moved or the extent stream is converted to a large stream.
        /// </summary>
        ERROR_CONVERT_TO_LARGE = 600, // 0x00000258
        /// <summary>
        /// The attempt to find the object found an object matching by ID on the volume but it is out of the scope of the handle used for the operation.
        /// </summary>
        ERROR_FOUND_OUT_OF_SCOPE = 601, // 0x00000259
        /// <summary>
        /// The bucket array must be grown. Retry transaction after doing so.
        /// </summary>
        ERROR_ALLOCATE_BUCKET = 602, // 0x0000025A
        /// <summary>The user/kernel marshalling buffer has overflowed.</summary>
        ERROR_MARSHALL_OVERFLOW = 603, // 0x0000025B
        /// <summary>The supplied variant structure contains invalid data.</summary>
        ERROR_INVALID_VARIANT = 604, // 0x0000025C
        /// <summary>The specified buffer contains ill-formed data.</summary>
        ERROR_BAD_COMPRESSION_BUFFER = 605, // 0x0000025D
        /// <summary>
        /// {Audit Failed} An attempt to generate a security audit failed.
        /// </summary>
        ERROR_AUDIT_FAILED = 606, // 0x0000025E
        /// <summary>
        /// The timer resolution was not previously set by the current process.
        /// </summary>
        ERROR_TIMER_RESOLUTION_NOT_SET = 607, // 0x0000025F
        /// <summary>
        /// There is insufficient account information to log you on.
        /// </summary>
        ERROR_INSUFFICIENT_LOGON_INFO = 608, // 0x00000260
        /// <summary>
        /// {Invalid DLL Entrypoint} The dynamic link library %hs is not written correctly. The stack pointer has been left in an inconsistent state. The entrypoint should be declared as WINAPI or STDCALL. Select YES to fail the DLL load. Select NO to continue execution. Selecting NO may cause the application to operate incorrectly.
        /// </summary>
        ERROR_BAD_DLL_ENTRYPOINT = 609, // 0x00000261
        /// <summary>
        /// {Invalid Service Callback Entrypoint} The %hs service is not written correctly. The stack pointer has been left in an inconsistent state. The callback entrypoint should be declared as WINAPI or STDCALL. Selecting OK will cause the service to continue operation. However, the service process may operate incorrectly.
        /// </summary>
        ERROR_BAD_SERVICE_ENTRYPOINT = 610, // 0x00000262
        /// <summary>
        /// There is an IP address conflict with another system on the network.
        /// </summary>
        ERROR_IP_ADDRESS_CONFLICT1 = 611, // 0x00000263
        /// <summary>
        /// There is an IP address conflict with another system on the network.
        /// </summary>
        ERROR_IP_ADDRESS_CONFLICT2 = 612, // 0x00000264
        /// <summary>
        /// {Low On Registry Space} The system has reached the maximum size allowed for the system part of the registry. Additional storage requests will be ignored.
        /// </summary>
        ERROR_REGISTRY_QUOTA_LIMIT = 613, // 0x00000265
        /// <summary>
        /// A callback return system service cannot be executed when no callback is active.
        /// </summary>
        ERROR_NO_CALLBACK_ACTIVE = 614, // 0x00000266
        /// <summary>
        /// The password provided is too short to meet the policy of your user account. Please choose a longer password.
        /// </summary>
        ERROR_PWD_TOO_SHORT = 615, // 0x00000267
        /// <summary>
        /// The policy of your user account does not allow you to change passwords too frequently. This is done to prevent users from changing back to a familiar, but potentially discovered, password. If you feel your password has been compromised then please contact your administrator immediately to have a new one assigned.
        /// </summary>
        ERROR_PWD_TOO_RECENT = 616, // 0x00000268
        /// <summary>
        /// You have attempted to change your password to one that you have used in the past. The policy of your user account does not allow this. Please select a password that you have not previously used.
        /// </summary>
        ERROR_PWD_HISTORY_CONFLICT = 617, // 0x00000269
        /// <summary>The specified compression format is unsupported.</summary>
        ERROR_UNSUPPORTED_COMPRESSION = 618, // 0x0000026A
        /// <summary>
        /// The specified hardware profile configuration is invalid.
        /// </summary>
        ERROR_INVALID_HW_PROFILE = 619, // 0x0000026B
        /// <summary>
        /// The specified Plug and Play registry device path is invalid.
        /// </summary>
        ERROR_INVALID_PLUGPLAY_DEVICE_PATH = 620, // 0x0000026C
        /// <summary>
        /// The specified quota list is internally inconsistent with its descriptor.
        /// </summary>
        ERROR_QUOTA_LIST_INCONSISTENT = 621, // 0x0000026D
        /// <summary>
        /// {Windows Evaluation Notification} The evaluation period for this installation of Windows has expired. This system will shutdown in 1 hour. To restore access to this installation of Windows, please upgrade this installation using a licensed distribution of this product.
        /// </summary>
        ERROR_EVALUATION_EXPIRATION = 622, // 0x0000026E
        /// <summary>
        /// {Illegal System DLL Relocation} The system DLL %hs was relocated in memory. The application will not run properly. The relocation occurred because the DLL %hs occupied an address range reserved for Windows system DLLs. The vendor supplying the DLL should be contacted for a new DLL.
        /// </summary>
        ERROR_ILLEGAL_DLL_RELOCATION = 623, // 0x0000026F
        /// <summary>
        /// {DLL Initialization Failed} The application failed to initialize because the window station is shutting down.
        /// </summary>
        ERROR_DLL_INIT_FAILED_LOGOFF = 624, // 0x00000270
        /// <summary>
        /// The validation process needs to continue on to the next step.
        /// </summary>
        ERROR_VALIDATE_CONTINUE = 625, // 0x00000271
        /// <summary>
        /// There are no more matches for the current index enumeration.
        /// </summary>
        ERROR_NO_MORE_MATCHES = 626, // 0x00000272
        /// <summary>
        /// The range could not be added to the range list because of a conflict.
        /// </summary>
        ERROR_RANGE_LIST_CONFLICT = 627, // 0x00000273
        /// <summary>
        /// The server process is running under a SID different than that required by client.
        /// </summary>
        ERROR_SERVER_SID_MISMATCH = 628, // 0x00000274
        /// <summary>A group marked use for deny only cannot be enabled.</summary>
        ERROR_CANT_ENABLE_DENY_ONLY = 629, // 0x00000275
        /// <summary>{EXCEPTION} Multiple floating point faults.</summary>
        ERROR_FLOAT_MULTIPLE_FAULTS = 630, // 0x00000276
        /// <summary>{EXCEPTION} Multiple floating point traps.</summary>
        ERROR_FLOAT_MULTIPLE_TRAPS = 631, // 0x00000277
        /// <summary>The requested interface is not supported.</summary>
        ERROR_NOINTERFACE = 632, // 0x00000278
        /// <summary>
        /// {System Standby Failed} The driver %hs does not support standby mode. Updating this driver may allow the system to go to standby mode.
        /// </summary>
        ERROR_DRIVER_FAILED_SLEEP = 633, // 0x00000279
        /// <summary>
        /// The system file %1 has become corrupt and has been replaced.
        /// </summary>
        ERROR_CORRUPT_SYSTEM_FILE = 634, // 0x0000027A
        /// <summary>
        /// {Virtual Memory Minimum Too Low} Your system is low on virtual memory. Windows is increasing the size of your virtual memory paging file. During this process, memory requests for some applications may be denied. For more information, see Help.
        /// </summary>
        ERROR_COMMITMENT_MINIMUM = 635, // 0x0000027B
        /// <summary>
        /// A device was removed so enumeration must be restarted.
        /// </summary>
        ERROR_PNP_RESTART_ENUMERATION = 636, // 0x0000027C
        /// <summary>
        /// {Fatal System Error} The system image %s is not properly signed. The file has been replaced with the signed file. The system has been shut down.
        /// </summary>
        ERROR_SYSTEM_IMAGE_BAD_SIGNATURE = 637, // 0x0000027D
        /// <summary>Device will not start without a reboot.</summary>
        ERROR_PNP_REBOOT_REQUIRED = 638, // 0x0000027E
        /// <summary>
        /// There is not enough power to complete the requested operation.
        /// </summary>
        ERROR_INSUFFICIENT_POWER = 639, // 0x0000027F
        /// <summary>ERROR_MULTIPLE_FAULT_VIOLATION</summary>
        ERROR_MULTIPLE_FAULT_VIOLATION = 640, // 0x00000280
        /// <summary>The system is in the process of shutting down.</summary>
        ERROR_SYSTEM_SHUTDOWN = 641, // 0x00000281
        /// <summary>
        /// An attempt to remove a processes DebugPort was made, but a port was not already associated with the process.
        /// </summary>
        ERROR_PORT_NOT_SET = 642, // 0x00000282
        /// <summary>
        /// This version of Windows is not compatible with the behavior version of directory forest, domain or domain controller.
        /// </summary>
        ERROR_DS_VERSION_CHECK_FAILURE = 643, // 0x00000283
        /// <summary>
        /// The specified range could not be found in the range list.
        /// </summary>
        ERROR_RANGE_NOT_FOUND = 644, // 0x00000284
        /// <summary>
        /// The driver was not loaded because the system is booting into safe mode.
        /// </summary>
        ERROR_NOT_SAFE_MODE_DRIVER = 646, // 0x00000286
        /// <summary>
        /// The driver was not loaded because it failed its initialization call.
        /// </summary>
        ERROR_FAILED_DRIVER_ENTRY = 647, // 0x00000287
        /// <summary>
        /// The \"%hs\" encountered an error while applying power or reading the device configuration. This may be caused by a failure of your hardware or by a poor connection.
        /// </summary>
        ERROR_DEVICE_ENUMERATION_ERROR = 648, // 0x00000288
        /// <summary>
        /// The create operation failed because the name contained at least one mount point which resolves to a volume to which the specified device object is not attached.
        /// </summary>
        ERROR_MOUNT_POINT_NOT_RESOLVED = 649, // 0x00000289
        /// <summary>
        /// The device object parameter is either not a valid device object or is not attached to the volume specified by the file name.
        /// </summary>
        ERROR_INVALID_DEVICE_OBJECT_PARAMETER = 650, // 0x0000028A
        /// <summary>
        /// A Machine Check Error has occurred. Please check the system eventlog for additional information.
        /// </summary>
        ERROR_MCA_OCCURED = 651, // 0x0000028B
        /// <summary>There was error [%2] processing the driver database.</summary>
        ERROR_DRIVER_DATABASE_ERROR = 652, // 0x0000028C
        /// <summary>System hive size has exceeded its limit.</summary>
        ERROR_SYSTEM_HIVE_TOO_LARGE = 653, // 0x0000028D
        /// <summary>
        /// The driver could not be loaded because a previous version of the driver is still in memory.
        /// </summary>
        ERROR_DRIVER_FAILED_PRIOR_UNLOAD = 654, // 0x0000028E
        /// <summary>
        /// {Volume Shadow Copy Service} Please wait while the Volume Shadow Copy Service prepares volume %hs for hibernation.
        /// </summary>
        ERROR_VOLSNAP_PREPARE_HIBERNATE = 655, // 0x0000028F
        /// <summary>
        /// The system has failed to hibernate (The error code is %hs). Hibernation will be disabled until the system is restarted.
        /// </summary>
        ERROR_HIBERNATION_FAILURE = 656, // 0x00000290
        /// <summary>
        /// The password provided is too long to meet the policy of your user account. Please choose a shorter password.
        /// </summary>
        ERROR_PWD_TOO_LONG = 657, // 0x00000291
        /// <summary>
        /// The requested operation could not be completed due to a file system limitation.
        /// </summary>
        ERROR_FILE_SYSTEM_LIMITATION = 665, // 0x00000299
        /// <summary>An assertion failure has occurred.</summary>
        ERROR_ASSERTION_FAILURE = 668, // 0x0000029C
        /// <summary>An error occurred in the ACPI subsystem.</summary>
        ERROR_ACPI_ERROR = 669, // 0x0000029D
        /// <summary>WOW Assertion Error.</summary>
        ERROR_WOW_ASSERTION = 670, // 0x0000029E
        /// <summary>
        /// A device is missing in the system BIOS MPS table. This device will not be used. Please contact your system vendor for system BIOS update.
        /// </summary>
        ERROR_PNP_BAD_MPS_TABLE = 671, // 0x0000029F
        /// <summary>A translator failed to translate resources.</summary>
        ERROR_PNP_TRANSLATION_FAILED = 672, // 0x000002A0
        /// <summary>A IRQ translator failed to translate resources.</summary>
        ERROR_PNP_IRQ_TRANSLATION_FAILED = 673, // 0x000002A1
        /// <summary>
        /// Driver %2 returned invalid ID for a child device (%3).
        /// </summary>
        ERROR_PNP_INVALID_ID = 674, // 0x000002A2
        /// <summary>
        /// {Kernel Debugger Awakened} the system debugger was awakened by an interrupt.
        /// </summary>
        ERROR_WAKE_SYSTEM_DEBUGGER = 675, // 0x000002A3
        /// <summary>
        /// {Handles Closed} Handles to objects have been automatically closed as a result of the requested operation.
        /// </summary>
        ERROR_HANDLES_CLOSED = 676, // 0x000002A4
        /// <summary>
        /// {Too Much Information} The specified access control list (ACL) contained more information than was expected.
        /// </summary>
        ERROR_EXTRANEOUS_INFORMATION = 677, // 0x000002A5
        /// <summary>
        /// This warning level status indicates that the transaction state already exists for the registry sub-tree, but that a transaction commit was previously aborted. The commit has NOT been completed, but has not been rolled back either (so it may still be committed if desired).
        /// </summary>
        ERROR_RXACT_COMMIT_NECESSARY = 678, // 0x000002A6
        /// <summary>{Media Changed} The media may have changed.</summary>
        ERROR_MEDIA_CHECK = 679, // 0x000002A7
        /// <summary>
        /// {GUID Substitution} During the translation of a global identifier (GUID) to a Windows security ID (SID), no administratively-defined GUID prefix was found. A substitute prefix was used, which will not compromise system security. However, this may provide a more restrictive access than intended.
        /// </summary>
        ERROR_GUID_SUBSTITUTION_MADE = 680, // 0x000002A8
        /// <summary>
        /// The create operation stopped after reaching a symbolic link.
        /// </summary>
        ERROR_STOPPED_ON_SYMLINK = 681, // 0x000002A9
        /// <summary>A long jump has been executed.</summary>
        ERROR_LONGJUMP = 682, // 0x000002AA
        /// <summary>The Plug and Play query operation was not successful.</summary>
        ERROR_PLUGPLAY_QUERY_VETOED = 683, // 0x000002AB
        /// <summary>A frame consolidation has been executed.</summary>
        ERROR_UNWIND_CONSOLIDATE = 684, // 0x000002AC
        /// <summary>
        /// {Registry Hive Recovered} Registry hive (file): %hs was corrupted and it has been recovered. Some data might have been lost.
        /// </summary>
        ERROR_REGISTRY_HIVE_RECOVERED = 685, // 0x000002AD
        /// <summary>
        /// The application is attempting to run executable code from the module %hs. This may be insecure. An alternative, %hs, is available. Should the application use the secure module %hs?
        /// </summary>
        ERROR_DLL_MIGHT_BE_INSECURE = 686, // 0x000002AE
        /// <summary>
        /// The application is loading executable code from the module %hs. This is secure, but may be incompatible with previous releases of the operating system. An alternative, %hs, is available. Should the application use the secure module %hs?
        /// </summary>
        ERROR_DLL_MIGHT_BE_INCOMPATIBLE = 687, // 0x000002AF
        /// <summary>Debugger did not handle the exception.</summary>
        ERROR_DBG_EXCEPTION_NOT_HANDLED = 688, // 0x000002B0
        /// <summary>Debugger will reply later.</summary>
        ERROR_DBG_REPLY_LATER = 689, // 0x000002B1
        /// <summary>Debugger cannot provide handle.</summary>
        ERROR_DBG_UNABLE_TO_PROVIDE_HANDLE = 690, // 0x000002B2
        /// <summary>Debugger terminated thread.</summary>
        ERROR_DBG_TERMINATE_THREAD = 691, // 0x000002B3
        /// <summary>Debugger terminated process.</summary>
        ERROR_DBG_TERMINATE_PROCESS = 692, // 0x000002B4
        /// <summary>Debugger got control C.</summary>
        ERROR_DBG_CONTROL_C = 693, // 0x000002B5
        /// <summary>Debugger printed exception on control C.</summary>
        ERROR_DBG_PRINTEXCEPTION_C = 694, // 0x000002B6
        /// <summary>Debugger received RIP exception.</summary>
        ERROR_DBG_RIPEXCEPTION = 695, // 0x000002B7
        /// <summary>Debugger received control break.</summary>
        ERROR_DBG_CONTROL_BREAK = 696, // 0x000002B8
        /// <summary>Debugger command communication exception.</summary>
        ERROR_DBG_COMMAND_EXCEPTION = 697, // 0x000002B9
        /// <summary>
        /// {Object Exists} An attempt was made to create an object and the object name already existed.
        /// </summary>
        ERROR_OBJECT_NAME_EXISTS = 698, // 0x000002BA
        /// <summary>
        /// {Thread Suspended} A thread termination occurred while the thread was suspended. The thread was resumed, and termination proceeded.
        /// </summary>
        ERROR_THREAD_WAS_SUSPENDED = 699, // 0x000002BB
        /// <summary>
        /// {Image Relocated} An image file could not be mapped at the address specified in the image file. Local fixups must be performed on this image.
        /// </summary>
        ERROR_IMAGE_NOT_AT_BASE = 700, // 0x000002BC
        /// <summary>
        /// This informational level status indicates that a specified registry sub-tree transaction state did not yet exist and had to be created.
        /// </summary>
        ERROR_RXACT_STATE_CREATED = 701, // 0x000002BD
        /// <summary>
        /// {Segment Load} A virtual DOS machine (VDM) is loading, unloading, or moving an MS-DOS or Win16 program segment image. An exception is raised so a debugger can load, unload or track symbols and breakpoints within these 16-bit segments.
        /// </summary>
        ERROR_SEGMENT_NOTIFICATION = 702, // 0x000002BE
        /// <summary>
        /// {Invalid Current Directory} The process cannot switch to the startup current directory %hs. Select OK to set current directory to %hs, or select CANCEL to exit.
        /// </summary>
        ERROR_BAD_CURRENT_DIRECTORY = 703, // 0x000002BF
        /// <summary>
        /// {Redundant Read} To satisfy a read request, the NT fault-tolerant file system successfully read the requested data from a redundant copy. This was done because the file system encountered a failure on a member of the fault-tolerant volume, but was unable to reassign the failing area of the device.
        /// </summary>
        ERROR_FT_READ_RECOVERY_FROM_BACKUP = 704, // 0x000002C0
        /// <summary>
        /// {Redundant Write} To satisfy a write request, the NT fault-tolerant file system successfully wrote a redundant copy of the information. This was done because the file system encountered a failure on a member of the fault-tolerant volume, but was not able to reassign the failing area of the device.
        /// </summary>
        ERROR_FT_WRITE_RECOVERY = 705, // 0x000002C1
        /// <summary>
        /// {Machine Type Mismatch} The image file %hs is valid, but is for a machine type other than the current machine. Select OK to continue, or CANCEL to fail the DLL load.
        /// </summary>
        ERROR_IMAGE_MACHINE_TYPE_MISMATCH = 706, // 0x000002C2
        /// <summary>
        /// {Partial Data Received} The network transport returned partial data to its client. The remaining data will be sent later.
        /// </summary>
        ERROR_RECEIVE_PARTIAL = 707, // 0x000002C3
        /// <summary>
        /// {Expedited Data Received} The network transport returned data to its client that was marked as expedited by the remote system.
        /// </summary>
        ERROR_RECEIVE_EXPEDITED = 708, // 0x000002C4
        /// <summary>
        /// {Partial Expedited Data Received} The network transport returned partial data to its client and this data was marked as expedited by the remote system. The remaining data will be sent later.
        /// </summary>
        ERROR_RECEIVE_PARTIAL_EXPEDITED = 709, // 0x000002C5
        /// <summary>
        /// {TDI Event Done} The TDI indication has completed successfully.
        /// </summary>
        ERROR_EVENT_DONE = 710, // 0x000002C6
        /// <summary>
        /// {TDI Event Pending} The TDI indication has entered the pending state.
        /// </summary>
        ERROR_EVENT_PENDING = 711, // 0x000002C7
        /// <summary>Checking file system on %wZ.</summary>
        ERROR_CHECKING_FILE_SYSTEM = 712, // 0x000002C8
        /// <summary>{Fatal Application Exit} %hs.</summary>
        ERROR_FATAL_APP_EXIT = 713, // 0x000002C9
        /// <summary>
        /// The specified registry key is referenced by a predefined handle.
        /// </summary>
        ERROR_PREDEFINED_HANDLE = 714, // 0x000002CA
        /// <summary>
        /// {Page Unlocked} The page protection of a locked page was changed to 'No Access' and the page was unlocked from memory and from the process.
        /// </summary>
        ERROR_WAS_UNLOCKED = 715, // 0x000002CB
        /// <summary>%hs</summary>
        ERROR_SERVICE_NOTIFICATION = 716, // 0x000002CC
        /// <summary>
        /// {Page Locked} One of the pages to lock was already locked.
        /// </summary>
        ERROR_WAS_LOCKED = 717, // 0x000002CD
        /// <summary>Application popup: %1 : %2</summary>
        ERROR_LOG_HARD_ERROR = 718, // 0x000002CE
        /// <summary>ERROR_ALREADY_WIN32</summary>
        ERROR_ALREADY_WIN32 = 719, // 0x000002CF
        /// <summary>
        /// {Machine Type Mismatch} The image file %hs is valid, but is for a machine type other than the current machine.
        /// </summary>
        ERROR_IMAGE_MACHINE_TYPE_MISMATCH_EXE = 720, // 0x000002D0
        /// <summary>
        /// A yield execution was performed and no thread was available to run.
        /// </summary>
        ERROR_NO_YIELD_PERFORMED = 721, // 0x000002D1
        /// <summary>The resumable flag to a timer API was ignored.</summary>
        ERROR_TIMER_RESUME_IGNORED = 722, // 0x000002D2
        /// <summary>
        /// The arbiter has deferred arbitration of these resources to its parent.
        /// </summary>
        ERROR_ARBITRATION_UNHANDLED = 723, // 0x000002D3
        /// <summary>
        /// The inserted CardBus device cannot be started because of a configuration error on \"%hs\".
        /// </summary>
        ERROR_CARDBUS_NOT_SUPPORTED = 724, // 0x000002D4
        /// <summary>
        /// The CPUs in this multiprocessor system are not all the same revision level. To use all processors the operating system restricts itself to the features of the least capable processor in the system. Should problems occur with this system, contact the CPU manufacturer to see if this mix of processors is supported.
        /// </summary>
        ERROR_MP_PROCESSOR_MISMATCH = 725, // 0x000002D5
        /// <summary>The system was put into hibernation.</summary>
        ERROR_HIBERNATED = 726, // 0x000002D6
        /// <summary>The system was resumed from hibernation.</summary>
        ERROR_RESUME_HIBERNATION = 727, // 0x000002D7
        /// <summary>
        /// Windows has detected that the system firmware (BIOS) was updated [previous firmware date = %2, current firmware date %3].
        /// </summary>
        ERROR_FIRMWARE_UPDATED = 728, // 0x000002D8
        /// <summary>
        /// A device driver is leaking locked I/O pages causing system degradation. The system has automatically enabled tracking code in order to try and catch the culprit.
        /// </summary>
        ERROR_DRIVERS_LEAKING_LOCKED_PAGES = 729, // 0x000002D9
        /// <summary>The system has awoken.</summary>
        ERROR_WAKE_SYSTEM = 730, // 0x000002DA
        /// <summary>ERROR_WAIT_1</summary>
        ERROR_WAIT_1 = 731, // 0x000002DB
        /// <summary>ERROR_WAIT_2</summary>
        ERROR_WAIT_2 = 732, // 0x000002DC
        /// <summary>ERROR_WAIT_3</summary>
        ERROR_WAIT_3 = 733, // 0x000002DD
        /// <summary>ERROR_WAIT_63</summary>
        ERROR_WAIT_63 = 734, // 0x000002DE
        /// <summary>ERROR_ABANDONED_WAIT_0</summary>
        ERROR_ABANDONED_WAIT_0 = 735, // 0x000002DF
        /// <summary>ERROR_ABANDONED_WAIT_63</summary>
        ERROR_ABANDONED_WAIT_63 = 736, // 0x000002E0
        /// <summary>ERROR_USER_APC</summary>
        ERROR_USER_APC = 737, // 0x000002E1
        /// <summary>ERROR_KERNEL_APC</summary>
        ERROR_KERNEL_APC = 738, // 0x000002E2
        /// <summary>ERROR_ALERTED</summary>
        ERROR_ALERTED = 739, // 0x000002E3
        /// <summary>The requested operation requires elevation.</summary>
        ERROR_ELEVATION_REQUIRED = 740, // 0x000002E4
        /// <summary>
        /// A reparse should be performed by the Object Manager since the name of the file resulted in a symbolic link.
        /// </summary>
        ERROR_REPARSE = 741, // 0x000002E5
        /// <summary>
        /// An open/create operation completed while an oplock break is underway.
        /// </summary>
        ERROR_OPLOCK_BREAK_IN_PROGRESS = 742, // 0x000002E6
        /// <summary>A new volume has been mounted by a file system.</summary>
        ERROR_VOLUME_MOUNTED = 743, // 0x000002E7
        /// <summary>
        /// This success level status indicates that the transaction state already exists for the registry sub-tree, but that a transaction commit was previously aborted. The commit has now been completed.
        /// </summary>
        ERROR_RXACT_COMMITTED = 744, // 0x000002E8
        /// <summary>
        /// This indicates that a notify change request has been completed due to closing the handle which made the notify change request.
        /// </summary>
        ERROR_NOTIFY_CLEANUP = 745, // 0x000002E9
        /// <summary>
        /// {Connect Failure on Primary Transport} An attempt was made to connect to the remote server %hs on the primary transport, but the connection failed. The computer WAS able to connect on a secondary transport.
        /// </summary>
        ERROR_PRIMARY_TRANSPORT_CONNECT_FAILED = 746, // 0x000002EA
        /// <summary>Page fault was a transition fault.</summary>
        ERROR_PAGE_FAULT_TRANSITION = 747, // 0x000002EB
        /// <summary>Page fault was a demand zero fault.</summary>
        ERROR_PAGE_FAULT_DEMAND_ZERO = 748, // 0x000002EC
        /// <summary>Page fault was a demand zero fault.</summary>
        ERROR_PAGE_FAULT_COPY_ON_WRITE = 749, // 0x000002ED
        /// <summary>Page fault was a demand zero fault.</summary>
        ERROR_PAGE_FAULT_GUARD_PAGE = 750, // 0x000002EE
        /// <summary>
        /// Page fault was satisfied by reading from a secondary storage device.
        /// </summary>
        ERROR_PAGE_FAULT_PAGING_FILE = 751, // 0x000002EF
        /// <summary>Cached page was locked during operation.</summary>
        ERROR_CACHE_PAGE_LOCKED = 752, // 0x000002F0
        /// <summary>Crash dump exists in paging file.</summary>
        ERROR_CRASH_DUMP = 753, // 0x000002F1
        /// <summary>Specified buffer contains all zeros.</summary>
        ERROR_BUFFER_ALL_ZEROS = 754, // 0x000002F2
        /// <summary>
        /// A reparse should be performed by the Object Manager since the name of the file resulted in a symbolic link.
        /// </summary>
        ERROR_REPARSE_OBJECT = 755, // 0x000002F3
        /// <summary>
        /// The device has succeeded a query-stop and its resource requirements have changed.
        /// </summary>
        ERROR_RESOURCE_REQUIREMENTS_CHANGED = 756, // 0x000002F4
        /// <summary>
        /// The translator has translated these resources into the global space and no further translations should be performed.
        /// </summary>
        ERROR_TRANSLATION_COMPLETE = 757, // 0x000002F5
        /// <summary>
        /// A process being terminated has no threads to terminate.
        /// </summary>
        ERROR_NOTHING_TO_TERMINATE = 758, // 0x000002F6
        /// <summary>The specified process is not part of a job.</summary>
        ERROR_PROCESS_NOT_IN_JOB = 759, // 0x000002F7
        /// <summary>The specified process is part of a job.</summary>
        ERROR_PROCESS_IN_JOB = 760, // 0x000002F8
        /// <summary>
        /// {Volume Shadow Copy Service} The system is now ready for hibernation.
        /// </summary>
        ERROR_VOLSNAP_HIBERNATE_READY = 761, // 0x000002F9
        /// <summary>
        /// A file system or file system filter driver has successfully completed an FsFilter operation.
        /// </summary>
        ERROR_FSFILTER_OP_COMPLETED_SUCCESSFULLY = 762, // 0x000002FA
        /// <summary>The specified interrupt vector was already connected.</summary>
        ERROR_INTERRUPT_VECTOR_ALREADY_CONNECTED = 763, // 0x000002FB
        /// <summary>The specified interrupt vector is still connected.</summary>
        ERROR_INTERRUPT_STILL_CONNECTED = 764, // 0x000002FC
        /// <summary>An operation is blocked waiting for an oplock.</summary>
        ERROR_WAIT_FOR_OPLOCK = 765, // 0x000002FD
        /// <summary>Debugger handled exception.</summary>
        ERROR_DBG_EXCEPTION_HANDLED = 766, // 0x000002FE
        /// <summary>Debugger continued.</summary>
        ERROR_DBG_CONTINUE = 767, // 0x000002FF
        /// <summary>
        /// An exception occurred in a user mode callback and the kernel callback frame should be removed.
        /// </summary>
        ERROR_CALLBACK_POP_STACK = 768, // 0x00000300
        /// <summary>Compression is disabled for this volume.</summary>
        ERROR_COMPRESSION_DISABLED = 769, // 0x00000301
        /// <summary>
        /// The data provider cannot fetch backwards through a result set.
        /// </summary>
        ERROR_CANTFETCHBACKWARDS = 770, // 0x00000302
        /// <summary>
        /// The data provider cannot scroll backwards through a result set.
        /// </summary>
        ERROR_CANTSCROLLBACKWARDS = 771, // 0x00000303
        /// <summary>
        /// The data provider requires that previously fetched data is released before asking for more data.
        /// </summary>
        ERROR_ROWSNOTRELEASED = 772, // 0x00000304
        /// <summary>
        /// The data provider was not able to interpret the flags set for a column binding in an accessor.
        /// </summary>
        ERROR_BAD_ACCESSOR_FLAGS = 773, // 0x00000305
        /// <summary>
        /// One or more errors occurred while processing the request.
        /// </summary>
        ERROR_ERRORS_ENCOUNTERED = 774, // 0x00000306
        /// <summary>
        /// The implementation is not capable of performing the request.
        /// </summary>
        ERROR_NOT_CAPABLE = 775, // 0x00000307
        /// <summary>
        /// The client of a component requested an operation which is not valid given the state of the component instance.
        /// </summary>
        ERROR_REQUEST_OUT_OF_SEQUENCE = 776, // 0x00000308
        /// <summary>A version number could not be parsed.</summary>
        ERROR_VERSION_PARSE_ERROR = 777, // 0x00000309
        /// <summary>The iterator's start position is invalid.</summary>
        ERROR_BADSTARTPOSITION = 778, // 0x0000030A
        /// <summary>
        /// The hardware has reported an uncorrectable memory error.
        /// </summary>
        ERROR_MEMORY_HARDWARE = 779, // 0x0000030B
        /// <summary>
        /// The attempted operation required self healing to be enabled.
        /// </summary>
        ERROR_DISK_REPAIR_DISABLED = 780, // 0x0000030C
        /// <summary>
        /// The Desktop heap encountered an error while allocating session memory. There is more information in the system event log.
        /// </summary>
        ERROR_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE = 781, // 0x0000030D
        /// <summary>
        /// The system power state is transitioning from %2 to %3.
        /// </summary>
        ERROR_SYSTEM_POWERSTATE_TRANSITION = 782, // 0x0000030E
        /// <summary>
        /// The system power state is transitioning from %2 to %3 but could enter %4.
        /// </summary>
        ERROR_SYSTEM_POWERSTATE_COMPLEX_TRANSITION = 783, // 0x0000030F
        /// <summary>
        /// A thread is getting dispatched with MCA EXCEPTION because of MCA.
        /// </summary>
        ERROR_MCA_EXCEPTION = 784, // 0x00000310
        /// <summary>Access to %1 is monitored by policy rule %2.</summary>
        ERROR_ACCESS_AUDIT_BY_POLICY = 785, // 0x00000311
        /// <summary>
        /// Access to %1 has been restricted by your Administrator by policy rule %2.
        /// </summary>
        ERROR_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY = 786, // 0x00000312
        /// <summary>
        /// A valid hibernation file has been invalidated and should be abandoned.
        /// </summary>
        ERROR_ABANDON_HIBERFILE = 787, // 0x00000313
        /// <summary>
        /// {Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. This error may be caused by network connectivity issues. Please try to save this file elsewhere.
        /// </summary>
        ERROR_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED = 788, // 0x00000314
        /// <summary>
        /// {Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. This error was returned by the server on which the file exists. Please try to save this file elsewhere.
        /// </summary>
        ERROR_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR = 789, // 0x00000315
        /// <summary>
        /// {Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. This error may be caused if the device has been removed or the media is write-protected.
        /// </summary>
        ERROR_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR = 790, // 0x00000316
        /// <summary>
        /// The resources required for this device conflict with the MCFG table.
        /// </summary>
        ERROR_BAD_MCFG_TABLE = 791, // 0x00000317
        /// <summary>
        /// The volume repair could not be performed while it is online. Please schedule to take the volume offline so that it can be repaired.
        /// </summary>
        ERROR_DISK_REPAIR_REDIRECTED = 792, // 0x00000318
        /// <summary>The volume repair was not successful.</summary>
        ERROR_DISK_REPAIR_UNSUCCESSFUL = 793, // 0x00000319
        /// <summary>
        /// One of the volume corruption logs is full. Further corruptions that may be detected won't be logged.
        /// </summary>
        ERROR_CORRUPT_LOG_OVERFULL = 794, // 0x0000031A
        /// <summary>
        /// One of the volume corruption logs is internally corrupted and needs to be recreated. The volume may contain undetected corruptions and must be scanned.
        /// </summary>
        ERROR_CORRUPT_LOG_CORRUPTED = 795, // 0x0000031B
        /// <summary>
        /// One of the volume corruption logs is unavailable for being operated on.
        /// </summary>
        ERROR_CORRUPT_LOG_UNAVAILABLE = 796, // 0x0000031C
        /// <summary>
        /// One of the volume corruption logs was deleted while still having corruption records in them. The volume contains detected corruptions and must be scanned.
        /// </summary>
        ERROR_CORRUPT_LOG_DELETED_FULL = 797, // 0x0000031D
        /// <summary>
        /// One of the volume corruption logs was cleared by chkdsk and no longer contains real corruptions.
        /// </summary>
        ERROR_CORRUPT_LOG_CLEARED = 798, // 0x0000031E
        /// <summary>
        /// Orphaned files exist on the volume but could not be recovered because no more new names could be created in the recovery directory. Files must be moved from the recovery directory.
        /// </summary>
        ERROR_ORPHAN_NAME_EXHAUSTED = 799, // 0x0000031F
        /// <summary>
        /// The oplock that was associated with this handle is now associated with a different handle.
        /// </summary>
        ERROR_OPLOCK_SWITCHED_TO_NEW_HANDLE = 800, // 0x00000320
        /// <summary>
        /// An oplock of the requested level cannot be granted. An oplock of a lower level may be available.
        /// </summary>
        ERROR_CANNOT_GRANT_REQUESTED_OPLOCK = 801, // 0x00000321
        /// <summary>
        /// The operation did not complete successfully because it would cause an oplock to be broken. The caller has requested that existing oplocks not be broken.
        /// </summary>
        ERROR_CANNOT_BREAK_OPLOCK = 802, // 0x00000322
        /// <summary>
        /// The handle with which this oplock was associated has been closed. The oplock is now broken.
        /// </summary>
        ERROR_OPLOCK_HANDLE_CLOSED = 803, // 0x00000323
        /// <summary>
        /// The specified access control entry (ACE) does not contain a condition.
        /// </summary>
        ERROR_NO_ACE_CONDITION = 804, // 0x00000324
        /// <summary>
        /// The specified access control entry (ACE) contains an invalid condition.
        /// </summary>
        ERROR_INVALID_ACE_CONDITION = 805, // 0x00000325
        /// <summary>Access to the specified file handle has been revoked.</summary>
        ERROR_FILE_HANDLE_REVOKED = 806, // 0x00000326
        /// <summary>
        /// An image file was mapped at a different address from the one specified in the image file but fixups will still be automatically performed on the image.
        /// </summary>
        ERROR_IMAGE_AT_DIFFERENT_BASE = 807, // 0x00000327
        /// <summary>Access to the extended attribute was denied.</summary>
        ERROR_EA_ACCESS_DENIED = 994, // 0x000003E2
        /// <summary>
        /// The I/O operation has been aborted because of either a thread exit or an application request.
        /// </summary>
        ERROR_OPERATION_ABORTED = 995, // 0x000003E3
        /// <summary>Overlapped I/O event is not in a signaled state.</summary>
        ERROR_IO_INCOMPLETE = 996, // 0x000003E4
        /// <summary>Overlapped I/O operation is in progress.</summary>
        ERROR_IO_PENDING = 997, // 0x000003E5
        /// <summary>Invalid access to memory location.</summary>
        ERROR_NOACCESS = 998, // 0x000003E6
        /// <summary>Error performing inpage operation.</summary>
        ERROR_SWAPERROR = 999, // 0x000003E7
        /// <summary>Recursion too deep; the stack overflowed.</summary>
        ERROR_STACK_OVERFLOW = 1001, // 0x000003E9
        /// <summary>The window cannot act on the sent message.</summary>
        ERROR_INVALID_MESSAGE = 1002, // 0x000003EA
        /// <summary>Cannot complete this function.</summary>
        ERROR_CAN_NOT_COMPLETE = 1003, // 0x000003EB
        /// <summary>Invalid flags.</summary>
        ERROR_INVALID_FLAGS = 1004, // 0x000003EC
        /// <summary>
        /// The volume does not contain a recognized file system. Please make sure that all required file system drivers are loaded and that the volume is not corrupted.
        /// </summary>
        ERROR_UNRECOGNIZED_VOLUME = 1005, // 0x000003ED
        /// <summary>
        /// The volume for a file has been externally altered so that the opened file is no longer valid.
        /// </summary>
        ERROR_FILE_INVALID = 1006, // 0x000003EE
        /// <summary>
        /// The requested operation cannot be performed in full-screen mode.
        /// </summary>
        ERROR_FULLSCREEN_MODE = 1007, // 0x000003EF
        /// <summary>
        /// An attempt was made to reference a token that does not exist.
        /// </summary>
        ERROR_NO_TOKEN = 1008, // 0x000003F0
        /// <summary>The configuration registry database is corrupt.</summary>
        ERROR_BADDB = 1009, // 0x000003F1
        /// <summary>The configuration registry key is invalid.</summary>
        ERROR_BADKEY = 1010, // 0x000003F2
        /// <summary>The configuration registry key could not be opened.</summary>
        ERROR_CANTOPEN = 1011, // 0x000003F3
        /// <summary>The configuration registry key could not be read.</summary>
        ERROR_CANTREAD = 1012, // 0x000003F4
        /// <summary>The configuration registry key could not be written.</summary>
        ERROR_CANTWRITE = 1013, // 0x000003F5
        /// <summary>
        /// One of the files in the registry database had to be recovered by use of a log or alternate copy. The recovery was successful.
        /// </summary>
        ERROR_REGISTRY_RECOVERED = 1014, // 0x000003F6
        /// <summary>
        /// The registry is corrupted. The structure of one of the files containing registry data is corrupted, or the system's memory image of the file is corrupted, or the file could not be recovered because the alternate copy or log was absent or corrupted.
        /// </summary>
        ERROR_REGISTRY_CORRUPT = 1015, // 0x000003F7
        /// <summary>
        /// An I/O operation initiated by the registry failed unrecoverably. The registry could not read in, or write out, or flush, one of the files that contain the system's image of the registry.
        /// </summary>
        ERROR_REGISTRY_IO_FAILED = 1016, // 0x000003F8
        /// <summary>
        /// The system has attempted to load or restore a file into the registry, but the specified file is not in a registry file format.
        /// </summary>
        ERROR_NOT_REGISTRY_FILE = 1017, // 0x000003F9
        /// <summary>
        /// Illegal operation attempted on a registry key that has been marked for deletion.
        /// </summary>
        ERROR_KEY_DELETED = 1018, // 0x000003FA
        /// <summary>
        /// System could not allocate the required space in a registry log.
        /// </summary>
        ERROR_NO_LOG_SPACE = 1019, // 0x000003FB
        /// <summary>
        /// Cannot create a symbolic link in a registry key that already has subkeys or values.
        /// </summary>
        ERROR_KEY_HAS_CHILDREN = 1020, // 0x000003FC
        /// <summary>
        /// Cannot create a stable subkey under a volatile parent key.
        /// </summary>
        ERROR_CHILD_MUST_BE_VOLATILE = 1021, // 0x000003FD
        /// <summary>
        /// A notify change request is being completed and the information is not being returned in the caller's buffer. The caller now needs to enumerate the files to find the changes.
        /// </summary>
        ERROR_NOTIFY_ENUM_DIR = 1022, // 0x000003FE
        /// <summary>
        /// A stop control has been sent to a service that other running services are dependent on.
        /// </summary>
        ERROR_DEPENDENT_SERVICES_RUNNING = 1051, // 0x0000041B
        /// <summary>The requested control is not valid for this service.</summary>
        ERROR_INVALID_SERVICE_CONTROL = 1052, // 0x0000041C
        /// <summary>
        /// The service did not respond to the start or control request in a timely fashion.
        /// </summary>
        ERROR_SERVICE_REQUEST_TIMEOUT = 1053, // 0x0000041D
        /// <summary>A thread could not be created for the service.</summary>
        ERROR_SERVICE_NO_THREAD = 1054, // 0x0000041E
        /// <summary>The service database is locked.</summary>
        ERROR_SERVICE_DATABASE_LOCKED = 1055, // 0x0000041F
        /// <summary>An instance of the service is already running.</summary>
        ERROR_SERVICE_ALREADY_RUNNING = 1056, // 0x00000420
        /// <summary>
        /// The account name is invalid or does not exist, or the password is invalid for the account name specified.
        /// </summary>
        ERROR_INVALID_SERVICE_ACCOUNT = 1057, // 0x00000421
        /// <summary>
        /// The service cannot be started, either because it is disabled or because it has no enabled devices associated with it.
        /// </summary>
        ERROR_SERVICE_DISABLED = 1058, // 0x00000422
        /// <summary>Circular service dependency was specified.</summary>
        ERROR_CIRCULAR_DEPENDENCY = 1059, // 0x00000423
        /// <summary>
        /// The specified service does not exist as an installed service.
        /// </summary>
        ERROR_SERVICE_DOES_NOT_EXIST = 1060, // 0x00000424
        /// <summary>
        /// The service cannot accept control messages at this time.
        /// </summary>
        ERROR_SERVICE_CANNOT_ACCEPT_CTRL = 1061, // 0x00000425
        /// <summary>The service has not been started.</summary>
        ERROR_SERVICE_NOT_ACTIVE = 1062, // 0x00000426
        /// <summary>
        /// The service process could not connect to the service controller.
        /// </summary>
        ERROR_FAILED_SERVICE_CONTROLLER_CONNECT = 1063, // 0x00000427
        /// <summary>
        /// An exception occurred in the service when handling the control request.
        /// </summary>
        ERROR_EXCEPTION_IN_SERVICE = 1064, // 0x00000428
        /// <summary>The database specified does not exist.</summary>
        ERROR_DATABASE_DOES_NOT_EXIST = 1065, // 0x00000429
        /// <summary>
        /// The service has returned a service-specific error code.
        /// </summary>
        ERROR_SERVICE_SPECIFIC_ERROR = 1066, // 0x0000042A
        /// <summary>The process terminated unexpectedly.</summary>
        ERROR_PROCESS_ABORTED = 1067, // 0x0000042B
        /// <summary>The dependency service or group failed to start.</summary>
        ERROR_SERVICE_DEPENDENCY_FAIL = 1068, // 0x0000042C
        /// <summary>The service did not start due to a logon failure.</summary>
        ERROR_SERVICE_LOGON_FAILED = 1069, // 0x0000042D
        /// <summary>
        /// After starting, the service hung in a start-pending state.
        /// </summary>
        ERROR_SERVICE_START_HANG = 1070, // 0x0000042E
        /// <summary>The specified service database lock is invalid.</summary>
        ERROR_INVALID_SERVICE_LOCK = 1071, // 0x0000042F
        /// <summary>The specified service has been marked for deletion.</summary>
        ERROR_SERVICE_MARKED_FOR_DELETE = 1072, // 0x00000430
        /// <summary>The specified service already exists.</summary>
        ERROR_SERVICE_EXISTS = 1073, // 0x00000431
        /// <summary>
        /// The system is currently running with the last-known-good configuration.
        /// </summary>
        ERROR_ALREADY_RUNNING_LKG = 1074, // 0x00000432
        /// <summary>
        /// The dependency service does not exist or has been marked for deletion.
        /// </summary>
        ERROR_SERVICE_DEPENDENCY_DELETED = 1075, // 0x00000433
        /// <summary>
        /// The current boot has already been accepted for use as the last-known-good control set.
        /// </summary>
        ERROR_BOOT_ALREADY_ACCEPTED = 1076, // 0x00000434
        /// <summary>
        /// No attempts to start the service have been made since the last boot.
        /// </summary>
        ERROR_SERVICE_NEVER_STARTED = 1077, // 0x00000435
        /// <summary>
        /// The name is already in use as either a service name or a service display name.
        /// </summary>
        ERROR_DUPLICATE_SERVICE_NAME = 1078, // 0x00000436
        /// <summary>
        /// The account specified for this service is different from the account specified for other services running in the same process.
        /// </summary>
        ERROR_DIFFERENT_SERVICE_ACCOUNT = 1079, // 0x00000437
        /// <summary>
        /// Failure actions can only be set for Win32 services, not for drivers.
        /// </summary>
        ERROR_CANNOT_DETECT_DRIVER_FAILURE = 1080, // 0x00000438
        /// <summary>
        /// This service runs in the same process as the service control manager. Therefore, the service control manager cannot take action if this service's process terminates unexpectedly.
        /// </summary>
        ERROR_CANNOT_DETECT_PROCESS_ABORT = 1081, // 0x00000439
        /// <summary>
        /// No recovery program has been configured for this service.
        /// </summary>
        ERROR_NO_RECOVERY_PROGRAM = 1082, // 0x0000043A
        /// <summary>
        /// The executable program that this service is configured to run in does not implement the service.
        /// </summary>
        ERROR_SERVICE_NOT_IN_EXE = 1083, // 0x0000043B
        /// <summary>This service cannot be started in Safe Mode.</summary>
        ERROR_NOT_SAFEBOOT_SERVICE = 1084, // 0x0000043C
        /// <summary>The physical end of the tape has been reached.</summary>
        ERROR_END_OF_MEDIA = 1100, // 0x0000044C
        /// <summary>A tape access reached a filemark.</summary>
        ERROR_FILEMARK_DETECTED = 1101, // 0x0000044D
        /// <summary>
        /// The beginning of the tape or a partition was encountered.
        /// </summary>
        ERROR_BEGINNING_OF_MEDIA = 1102, // 0x0000044E
        /// <summary>A tape access reached the end of a set of files.</summary>
        ERROR_SETMARK_DETECTED = 1103, // 0x0000044F
        /// <summary>No more data is on the tape.</summary>
        ERROR_NO_DATA_DETECTED = 1104, // 0x00000450
        /// <summary>Tape could not be partitioned.</summary>
        ERROR_PARTITION_FAILURE = 1105, // 0x00000451
        /// <summary>
        /// When accessing a new tape of a multivolume partition, the current block size is incorrect.
        /// </summary>
        ERROR_INVALID_BLOCK_LENGTH = 1106, // 0x00000452
        /// <summary>
        /// Tape partition information could not be found when loading a tape.
        /// </summary>
        ERROR_DEVICE_NOT_PARTITIONED = 1107, // 0x00000453
        /// <summary>Unable to lock the media eject mechanism.</summary>
        ERROR_UNABLE_TO_LOCK_MEDIA = 1108, // 0x00000454
        /// <summary>Unable to unload the media.</summary>
        ERROR_UNABLE_TO_UNLOAD_MEDIA = 1109, // 0x00000455
        /// <summary>The media in the drive may have changed.</summary>
        ERROR_MEDIA_CHANGED = 1110, // 0x00000456
        /// <summary>The I/O bus was reset.</summary>
        ERROR_BUS_RESET = 1111, // 0x00000457
        /// <summary>No media in drive.</summary>
        ERROR_NO_MEDIA_IN_DRIVE = 1112, // 0x00000458
        /// <summary>
        /// No mapping for the Unicode character exists in the target multi-byte code page.
        /// </summary>
        ERROR_NO_UNICODE_TRANSLATION = 1113, // 0x00000459
        /// <summary>
        /// A dynamic link library (DLL) initialization routine failed.
        /// </summary>
        ERROR_DLL_INIT_FAILED = 1114, // 0x0000045A
        /// <summary>A system shutdown is in progress.</summary>
        ERROR_SHUTDOWN_IN_PROGRESS = 1115, // 0x0000045B
        /// <summary>
        /// Unable to abort the system shutdown because no shutdown was in progress.
        /// </summary>
        ERROR_NO_SHUTDOWN_IN_PROGRESS = 1116, // 0x0000045C
        /// <summary>
        /// The request could not be performed because of an I/O device error.
        /// </summary>
        ERROR_IO_DEVICE = 1117, // 0x0000045D
        /// <summary>
        /// No serial device was successfully initialized. The serial driver will unload.
        /// </summary>
        ERROR_SERIAL_NO_DEVICE = 1118, // 0x0000045E
        /// <summary>
        /// Unable to open a device that was sharing an interrupt request (IRQ) with other devices. At least one other device that uses that IRQ was already opened.
        /// </summary>
        ERROR_IRQ_BUSY = 1119, // 0x0000045F
        /// <summary>
        /// A serial I/O operation was completed by another write to the serial port. The IOCTL_SERIAL_XOFF_COUNTER reached zero.)
        /// </summary>
        ERROR_MORE_WRITES = 1120, // 0x00000460
        /// <summary>
        /// A serial I/O operation completed because the timeout period expired. The IOCTL_SERIAL_XOFF_COUNTER did not reach zero.)
        /// </summary>
        ERROR_COUNTER_TIMEOUT = 1121, // 0x00000461
        /// <summary>No ID address mark was found on the floppy disk.</summary>
        ERROR_FLOPPY_ID_MARK_NOT_FOUND = 1122, // 0x00000462
        /// <summary>
        /// Mismatch between the floppy disk sector ID field and the floppy disk controller track address.
        /// </summary>
        ERROR_FLOPPY_WRONG_CYLINDER = 1123, // 0x00000463
        /// <summary>
        /// The floppy disk controller reported an error that is not recognized by the floppy disk driver.
        /// </summary>
        ERROR_FLOPPY_UNKNOWN_ERROR = 1124, // 0x00000464
        /// <summary>
        /// The floppy disk controller returned inconsistent results in its registers.
        /// </summary>
        ERROR_FLOPPY_BAD_REGISTERS = 1125, // 0x00000465
        /// <summary>
        /// While accessing the hard disk, a recalibrate operation failed, even after retries.
        /// </summary>
        ERROR_DISK_RECALIBRATE_FAILED = 1126, // 0x00000466
        /// <summary>
        /// While accessing the hard disk, a disk operation failed even after retries.
        /// </summary>
        ERROR_DISK_OPERATION_FAILED = 1127, // 0x00000467
        /// <summary>
        /// While accessing the hard disk, a disk controller reset was needed, but even that failed.
        /// </summary>
        ERROR_DISK_RESET_FAILED = 1128, // 0x00000468
        /// <summary>Physical end of tape encountered.</summary>
        ERROR_EOM_OVERFLOW = 1129, // 0x00000469
        /// <summary>
        /// Not enough server storage is available to process this command.
        /// </summary>
        ERROR_NOT_ENOUGH_SERVER_MEMORY = 1130, // 0x0000046A
        /// <summary>A potential deadlock condition has been detected.</summary>
        ERROR_POSSIBLE_DEADLOCK = 1131, // 0x0000046B
        /// <summary>
        /// The base address or the file offset specified does not have the proper alignment.
        /// </summary>
        ERROR_MAPPED_ALIGNMENT = 1132, // 0x0000046C
        /// <summary>
        /// An attempt to change the system power state was vetoed by another application or driver.
        /// </summary>
        ERROR_SET_POWER_STATE_VETOED = 1140, // 0x00000474
        /// <summary>
        /// The system BIOS failed an attempt to change the system power state.
        /// </summary>
        ERROR_SET_POWER_STATE_FAILED = 1141, // 0x00000475
        /// <summary>
        /// An attempt was made to create more links on a file than the file system supports.
        /// </summary>
        ERROR_TOO_MANY_LINKS = 1142, // 0x00000476
        /// <summary>
        /// The specified program requires a newer version of Windows.
        /// </summary>
        ERROR_OLD_WIN_VERSION = 1150, // 0x0000047E
        /// <summary>
        /// The specified program is not a Windows or MS-DOS program.
        /// </summary>
        ERROR_APP_WRONG_OS = 1151, // 0x0000047F
        /// <summary>
        /// Cannot start more than one instance of the specified program.
        /// </summary>
        ERROR_SINGLE_INSTANCE_APP = 1152, // 0x00000480
        /// <summary>
        /// The specified program was written for an earlier version of Windows.
        /// </summary>
        ERROR_RMODE_APP = 1153, // 0x00000481
        /// <summary>
        /// One of the library files needed to run this application is damaged.
        /// </summary>
        ERROR_INVALID_DLL = 1154, // 0x00000482
        /// <summary>
        /// No application is associated with the specified file for this operation.
        /// </summary>
        ERROR_NO_ASSOCIATION = 1155, // 0x00000483
        /// <summary>
        /// An error occurred in sending the command to the application.
        /// </summary>
        ERROR_DDE_FAIL = 1156, // 0x00000484
        /// <summary>
        /// One of the library files needed to run this application cannot be found.
        /// </summary>
        ERROR_DLL_NOT_FOUND = 1157, // 0x00000485
        /// <summary>
        /// The current process has used all of its system allowance of handles for Window Manager objects.
        /// </summary>
        ERROR_NO_MORE_USER_HANDLES = 1158, // 0x00000486
        /// <summary>
        /// The message can be used only with synchronous operations.
        /// </summary>
        ERROR_MESSAGE_SYNC_ONLY = 1159, // 0x00000487
        /// <summary>The indicated source element has no media.</summary>
        ERROR_SOURCE_ELEMENT_EMPTY = 1160, // 0x00000488
        /// <summary>
        /// The indicated destination element already contains media.
        /// </summary>
        ERROR_DESTINATION_ELEMENT_FULL = 1161, // 0x00000489
        /// <summary>The indicated element does not exist.</summary>
        ERROR_ILLEGAL_ELEMENT_ADDRESS = 1162, // 0x0000048A
        /// <summary>
        /// The indicated element is part of a magazine that is not present.
        /// </summary>
        ERROR_MAGAZINE_NOT_PRESENT = 1163, // 0x0000048B
        /// <summary>
        /// The indicated device requires reinitialization due to hardware errors.
        /// </summary>
        ERROR_DEVICE_REINITIALIZATION_NEEDED = 1164, // 0x0000048C
        /// <summary>
        /// The device has indicated that cleaning is required before further operations are attempted.
        /// </summary>
        ERROR_DEVICE_REQUIRES_CLEANING = 1165, // 0x0000048D
        /// <summary>The device has indicated that its door is open.</summary>
        ERROR_DEVICE_DOOR_OPEN = 1166, // 0x0000048E
        /// <summary>The device is not connected.</summary>
        ERROR_DEVICE_NOT_CONNECTED = 1167, // 0x0000048F
        /// <summary>Element not found.</summary>
        ERROR_NOT_FOUND = 1168, // 0x00000490
        /// <summary>
        /// There was no match for the specified key in the index.
        /// </summary>
        ERROR_NO_MATCH = 1169, // 0x00000491
        /// <summary>
        /// The property set specified does not exist on the object.
        /// </summary>
        ERROR_SET_NOT_FOUND = 1170, // 0x00000492
        /// <summary>
        /// The point passed to GetMouseMovePoints is not in the buffer.
        /// </summary>
        ERROR_POINT_NOT_FOUND = 1171, // 0x00000493
        /// <summary>The tracking (workstation) service is not running.</summary>
        ERROR_NO_TRACKING_SERVICE = 1172, // 0x00000494
        /// <summary>The Volume ID could not be found.</summary>
        ERROR_NO_VOLUME_ID = 1173, // 0x00000495
        /// <summary>Unable to remove the file to be replaced.</summary>
        ERROR_UNABLE_TO_REMOVE_REPLACED = 1175, // 0x00000497
        /// <summary>
        /// Unable to move the replacement file to the file to be replaced. The file to be replaced has retained its original name.
        /// </summary>
        ERROR_UNABLE_TO_MOVE_REPLACEMENT = 1176, // 0x00000498
        /// <summary>
        /// Unable to move the replacement file to the file to be replaced. The file to be replaced has been renamed using the backup name.
        /// </summary>
        ERROR_UNABLE_TO_MOVE_REPLACEMENT_2 = 1177, // 0x00000499
        /// <summary>The volume change journal is being deleted.</summary>
        ERROR_JOURNAL_DELETE_IN_PROGRESS = 1178, // 0x0000049A
        /// <summary>The volume change journal is not active.</summary>
        ERROR_JOURNAL_NOT_ACTIVE = 1179, // 0x0000049B
        /// <summary>A file was found, but it may not be the correct file.</summary>
        ERROR_POTENTIAL_FILE_FOUND = 1180, // 0x0000049C
        /// <summary>The journal entry has been deleted from the journal.</summary>
        ERROR_JOURNAL_ENTRY_DELETED = 1181, // 0x0000049D
        /// <summary>A system shutdown has already been scheduled.</summary>
        ERROR_SHUTDOWN_IS_SCHEDULED = 1190, // 0x000004A6
        /// <summary>
        /// The system shutdown cannot be initiated because there are other users logged on to the computer.
        /// </summary>
        ERROR_SHUTDOWN_USERS_LOGGED_ON = 1191, // 0x000004A7
        /// <summary>The specified device name is invalid.</summary>
        ERROR_BAD_DEVICE = 1200, // 0x000004B0
        /// <summary>
        /// The device is not currently connected but it is a remembered connection.
        /// </summary>
        ERROR_CONNECTION_UNAVAIL = 1201, // 0x000004B1
        /// <summary>
        /// The local device name has a remembered connection to another network resource.
        /// </summary>
        ERROR_DEVICE_ALREADY_REMEMBERED = 1202, // 0x000004B2
        /// <summary>
        /// The network path was either typed incorrectly, does not exist, or the network provider is not currently available. Please try retyping the path or contact your network administrator.
        /// </summary>
        ERROR_NO_NET_OR_BAD_PATH = 1203, // 0x000004B3
        /// <summary>The specified network provider name is invalid.</summary>
        ERROR_BAD_PROVIDER = 1204, // 0x000004B4
        /// <summary>Unable to open the network connection profile.</summary>
        ERROR_CANNOT_OPEN_PROFILE = 1205, // 0x000004B5
        /// <summary>The network connection profile is corrupted.</summary>
        ERROR_BAD_PROFILE = 1206, // 0x000004B6
        /// <summary>Cannot enumerate a noncontainer.</summary>
        ERROR_NOT_CONTAINER = 1207, // 0x000004B7
        /// <summary>An extended error has occurred.</summary>
        ERROR_EXTENDED_ERROR = 1208, // 0x000004B8
        /// <summary>The format of the specified group name is invalid.</summary>
        ERROR_INVALID_GROUPNAME = 1209, // 0x000004B9
        /// <summary>The format of the specified computer name is invalid.</summary>
        ERROR_INVALID_COMPUTERNAME = 1210, // 0x000004BA
        /// <summary>The format of the specified event name is invalid.</summary>
        ERROR_INVALID_EVENTNAME = 1211, // 0x000004BB
        /// <summary>The format of the specified domain name is invalid.</summary>
        ERROR_INVALID_DOMAINNAME = 1212, // 0x000004BC
        /// <summary>The format of the specified service name is invalid.</summary>
        ERROR_INVALID_SERVICENAME = 1213, // 0x000004BD
        /// <summary>The format of the specified network name is invalid.</summary>
        ERROR_INVALID_NETNAME = 1214, // 0x000004BE
        /// <summary>The format of the specified share name is invalid.</summary>
        ERROR_INVALID_SHARENAME = 1215, // 0x000004BF
        /// <summary>The format of the specified password is invalid.</summary>
        ERROR_INVALID_PASSWORDNAME = 1216, // 0x000004C0
        /// <summary>The format of the specified message name is invalid.</summary>
        ERROR_INVALID_MESSAGENAME = 1217, // 0x000004C1
        /// <summary>
        /// The format of the specified message destination is invalid.
        /// </summary>
        ERROR_INVALID_MESSAGEDEST = 1218, // 0x000004C2
        /// <summary>
        /// Multiple connections to a server or shared resource by the same user, using more than one user name, are not allowed. Disconnect all previous connections to the server or shared resource and try again.
        /// </summary>
        ERROR_SESSION_CREDENTIAL_CONFLICT = 1219, // 0x000004C3
        /// <summary>
        /// An attempt was made to establish a session to a network server, but there are already too many sessions established to that server.
        /// </summary>
        ERROR_REMOTE_SESSION_LIMIT_EXCEEDED = 1220, // 0x000004C4
        /// <summary>
        /// The workgroup or domain name is already in use by another computer on the network.
        /// </summary>
        ERROR_DUP_DOMAINNAME = 1221, // 0x000004C5
        /// <summary>The network is not present or not started.</summary>
        ERROR_NO_NETWORK = 1222, // 0x000004C6
        /// <summary>The operation was canceled by the user.</summary>
        ERROR_CANCELLED = 1223, // 0x000004C7
        /// <summary>
        /// The requested operation cannot be performed on a file with a user-mapped section open.
        /// </summary>
        ERROR_USER_MAPPED_FILE = 1224, // 0x000004C8
        /// <summary>The remote computer refused the network connection.</summary>
        ERROR_CONNECTION_REFUSED = 1225, // 0x000004C9
        /// <summary>The network connection was gracefully closed.</summary>
        ERROR_GRACEFUL_DISCONNECT = 1226, // 0x000004CA
        /// <summary>
        /// The network transport endpoint already has an address associated with it.
        /// </summary>
        ERROR_ADDRESS_ALREADY_ASSOCIATED = 1227, // 0x000004CB
        /// <summary>
        /// An address has not yet been associated with the network endpoint.
        /// </summary>
        ERROR_ADDRESS_NOT_ASSOCIATED = 1228, // 0x000004CC
        /// <summary>
        /// An operation was attempted on a nonexistent network connection.
        /// </summary>
        ERROR_CONNECTION_INVALID = 1229, // 0x000004CD
        /// <summary>
        /// An invalid operation was attempted on an active network connection.
        /// </summary>
        ERROR_CONNECTION_ACTIVE = 1230, // 0x000004CE
        /// <summary>
        /// The network location cannot be reached. For information about network troubleshooting, see Windows Help.
        /// </summary>
        ERROR_NETWORK_UNREACHABLE = 1231, // 0x000004CF
        /// <summary>
        /// The network location cannot be reached. For information about network troubleshooting, see Windows Help.
        /// </summary>
        ERROR_HOST_UNREACHABLE = 1232, // 0x000004D0
        /// <summary>
        /// The network location cannot be reached. For information about network troubleshooting, see Windows Help.
        /// </summary>
        ERROR_PROTOCOL_UNREACHABLE = 1233, // 0x000004D1
        /// <summary>
        /// No service is operating at the destination network endpoint on the remote system.
        /// </summary>
        ERROR_PORT_UNREACHABLE = 1234, // 0x000004D2
        /// <summary>The request was aborted.</summary>
        ERROR_REQUEST_ABORTED = 1235, // 0x000004D3
        /// <summary>
        /// The network connection was aborted by the local system.
        /// </summary>
        ERROR_CONNECTION_ABORTED = 1236, // 0x000004D4
        /// <summary>
        /// The operation could not be completed. A retry should be performed.
        /// </summary>
        ERROR_RETRY = 1237, // 0x000004D5
        /// <summary>
        /// A connection to the server could not be made because the limit on the number of concurrent connections for this account has been reached.
        /// </summary>
        ERROR_CONNECTION_COUNT_LIMIT = 1238, // 0x000004D6
        /// <summary>
        /// Attempting to log in during an unauthorized time of day for this account.
        /// </summary>
        ERROR_LOGIN_TIME_RESTRICTION = 1239, // 0x000004D7
        /// <summary>
        /// The account is not authorized to log in from this station.
        /// </summary>
        ERROR_LOGIN_WKSTA_RESTRICTION = 1240, // 0x000004D8
        /// <summary>
        /// The network address could not be used for the operation requested.
        /// </summary>
        ERROR_INCORRECT_ADDRESS = 1241, // 0x000004D9
        /// <summary>The service is already registered.</summary>
        ERROR_ALREADY_REGISTERED = 1242, // 0x000004DA
        /// <summary>The specified service does not exist.</summary>
        ERROR_SERVICE_NOT_FOUND = 1243, // 0x000004DB
        /// <summary>
        /// The operation being requested was not performed because the user has not been authenticated.
        /// </summary>
        ERROR_NOT_AUTHENTICATED = 1244, // 0x000004DC
        /// <summary>
        /// The operation being requested was not performed because the user has not logged on to the network. The specified service does not exist.
        /// </summary>
        ERROR_NOT_LOGGED_ON = 1245, // 0x000004DD
        /// <summary>Continue with work in progress.</summary>
        ERROR_CONTINUE = 1246, // 0x000004DE
        /// <summary>
        /// An attempt was made to perform an initialization operation when initialization has already been completed.
        /// </summary>
        ERROR_ALREADY_INITIALIZED = 1247, // 0x000004DF
        /// <summary>No more local devices.</summary>
        ERROR_NO_MORE_DEVICES = 1248, // 0x000004E0
        /// <summary>The specified site does not exist.</summary>
        ERROR_NO_SUCH_SITE = 1249, // 0x000004E1
        /// <summary>
        /// A domain controller with the specified name already exists.
        /// </summary>
        ERROR_DOMAIN_CONTROLLER_EXISTS = 1250, // 0x000004E2
        /// <summary>
        /// This operation is supported only when you are connected to the server.
        /// </summary>
        ERROR_ONLY_IF_CONNECTED = 1251, // 0x000004E3
        /// <summary>
        /// The group policy framework should call the extension even if there are no changes.
        /// </summary>
        ERROR_OVERRIDE_NOCHANGES = 1252, // 0x000004E4
        /// <summary>The specified user does not have a valid profile.</summary>
        ERROR_BAD_USER_PROFILE = 1253, // 0x000004E5
        /// <summary>
        /// This operation is not supported on a computer running Windows Server 2003 for Small Business Server.
        /// </summary>
        ERROR_NOT_SUPPORTED_ON_SBS = 1254, // 0x000004E6
        /// <summary>The server machine is shutting down.</summary>
        ERROR_SERVER_SHUTDOWN_IN_PROGRESS = 1255, // 0x000004E7
        /// <summary>
        /// The remote system is not available. For information about network troubleshooting, see Windows Help.
        /// </summary>
        ERROR_HOST_DOWN = 1256, // 0x000004E8
        /// <summary>
        /// The security identifier provided is not from an account domain.
        /// </summary>
        ERROR_NON_ACCOUNT_SID = 1257, // 0x000004E9
        /// <summary>
        /// The security identifier provided does not have a domain component.
        /// </summary>
        ERROR_NON_DOMAIN_SID = 1258, // 0x000004EA
        /// <summary>
        /// AppHelp dialog canceled thus preventing the application from starting.
        /// </summary>
        ERROR_APPHELP_BLOCK = 1259, // 0x000004EB
        /// <summary>
        /// This program is blocked by group policy. For more information, contact your system administrator.
        /// </summary>
        ERROR_ACCESS_DISABLED_BY_POLICY = 1260, // 0x000004EC
        /// <summary>
        /// A program attempt to use an invalid register value. Normally caused by an uninitialized register. This error is Itanium specific.
        /// </summary>
        ERROR_REG_NAT_CONSUMPTION = 1261, // 0x000004ED
        /// <summary>The share is currently offline or does not exist.</summary>
        ERROR_CSCSHARE_OFFLINE = 1262, // 0x000004EE
        /// <summary>
        /// The Kerberos protocol encountered an error while validating the KDC certificate during smartcard logon. There is more information in the system event log.
        /// </summary>
        ERROR_PKINIT_FAILURE = 1263, // 0x000004EF
        /// <summary>
        /// The Kerberos protocol encountered an error while attempting to utilize the smartcard subsystem.
        /// </summary>
        ERROR_SMARTCARD_SUBSYSTEM_FAILURE = 1264, // 0x000004F0
        /// <summary>
        /// The system cannot contact a domain controller to service the authentication request. Please try again later.
        /// </summary>
        ERROR_DOWNGRADE_DETECTED = 1265, // 0x000004F1
        /// <summary>
        /// The machine is locked and cannot be shut down without the force option.
        /// </summary>
        ERROR_MACHINE_LOCKED = 1271, // 0x000004F7
        /// <summary>
        /// An application-defined callback gave invalid data when called.
        /// </summary>
        ERROR_CALLBACK_SUPPLIED_INVALID_DATA = 1273, // 0x000004F9
        /// <summary>
        /// The group policy framework should call the extension in the synchronous foreground policy refresh.
        /// </summary>
        ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED = 1274, // 0x000004FA
        /// <summary>This driver has been blocked from loading.</summary>
        ERROR_DRIVER_BLOCKED = 1275, // 0x000004FB
        /// <summary>
        /// A dynamic link library (DLL) referenced a module that was neither a DLL nor the process's executable image.
        /// </summary>
        ERROR_INVALID_IMPORT_OF_NON_DLL = 1276, // 0x000004FC
        /// <summary>
        /// Windows cannot open this program since it has been disabled.
        /// </summary>
        ERROR_ACCESS_DISABLED_WEBBLADE = 1277, // 0x000004FD
        /// <summary>
        /// Windows cannot open this program because the license enforcement system has been tampered with or become corrupted.
        /// </summary>
        ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER = 1278, // 0x000004FE
        /// <summary>A transaction recover failed.</summary>
        ERROR_RECOVERY_FAILURE = 1279, // 0x000004FF
        /// <summary>
        /// The current thread has already been converted to a fiber.
        /// </summary>
        ERROR_ALREADY_FIBER = 1280, // 0x00000500
        /// <summary>
        /// The current thread has already been converted from a fiber.
        /// </summary>
        ERROR_ALREADY_THREAD = 1281, // 0x00000501
        /// <summary>
        /// The system detected an overrun of a stack-based buffer in this application. This overrun could potentially allow a malicious user to gain control of this application.
        /// </summary>
        ERROR_STACK_BUFFER_OVERRUN = 1282, // 0x00000502
        /// <summary>
        /// Data present in one of the parameters is more than the function can operate on.
        /// </summary>
        ERROR_PARAMETER_QUOTA_EXCEEDED = 1283, // 0x00000503
        /// <summary>
        /// An attempt to do an operation on a debug object failed because the object is in the process of being deleted.
        /// </summary>
        ERROR_DEBUGGER_INACTIVE = 1284, // 0x00000504
        /// <summary>
        /// An attempt to delay-load a .dll or get a function address in a delay-loaded .dll failed.
        /// </summary>
        ERROR_DELAY_LOAD_FAILED = 1285, // 0x00000505
        /// <summary>
        /// %1 is a 16-bit application. You do not have permissions to execute 16-bit applications. Check your permissions with your system administrator.
        /// </summary>
        ERROR_VDM_DISALLOWED = 1286, // 0x00000506
        /// <summary>
        /// Insufficient information exists to identify the cause of failure.
        /// </summary>
        ERROR_UNIDENTIFIED_ERROR = 1287, // 0x00000507
        /// <summary>
        /// The parameter passed to a C runtime function is incorrect.
        /// </summary>
        ERROR_INVALID_CRUNTIME_PARAMETER = 1288, // 0x00000508
        /// <summary>
        /// The operation occurred beyond the valid data length of the file.
        /// </summary>
        ERROR_BEYOND_VDL = 1289, // 0x00000509
        /// <summary>
        /// The service start failed since one or more services in the same process have an incompatible service SID type  setting. A service with restricted service SID type can only coexist in the same process with other services  with a restricted SID type. If the service SID type for this service was just configured, the hosting process  must be restarted in order to start this service. On Windows Server 2003 and Windows XP, an unrestricted service cannot coexist in the  same process with other services. The service with the unrestricted service SID type must be moved to an owned  process in order to start this service.
        /// </summary>
        ERROR_INCOMPATIBLE_SERVICE_SID_TYPE = 1290, // 0x0000050A
        /// <summary>
        /// The process hosting the driver for this device has been terminated.
        /// </summary>
        ERROR_DRIVER_PROCESS_TERMINATED = 1291, // 0x0000050B
        /// <summary>
        /// An operation attempted to exceed an implementation-defined limit.
        /// </summary>
        ERROR_IMPLEMENTATION_LIMIT = 1292, // 0x0000050C
        /// <summary>
        /// Either the target process, or the target thread's containing process, is a protected process.
        /// </summary>
        ERROR_PROCESS_IS_PROTECTED = 1293, // 0x0000050D
        /// <summary>
        /// The service notification client is lagging too far behind the current state of services in the machine.
        /// </summary>
        ERROR_SERVICE_NOTIFY_CLIENT_LAGGING = 1294, // 0x0000050E
        /// <summary>
        /// The requested file operation failed because the storage quota was exceeded. To free up disk space, move files to a different location or delete unnecessary files. For more information, contact your system administrator.
        /// </summary>
        ERROR_DISK_QUOTA_EXCEEDED = 1295, // 0x0000050F
        /// <summary>
        /// The requested file operation failed because the storage policy blocks that type of file. For more information, contact your system administrator.
        /// </summary>
        ERROR_CONTENT_BLOCKED = 1296, // 0x00000510
        /// <summary>
        /// A privilege that the service requires to function properly does not exist in the service account configuration. You may use the Services Microsoft Management Console (MMC) snap-in (services.msc) and the Local Security Settings MMC snap-in (secpol.msc) to view the service configuration and the account configuration.
        /// </summary>
        ERROR_INCOMPATIBLE_SERVICE_PRIVILEGE = 1297, // 0x00000511
        /// <summary>
        /// A thread involved in this operation appears to be unresponsive.
        /// </summary>
        ERROR_APP_HANG = 1298, // 0x00000512
        /// <summary>
        /// Indicates a particular Security ID may not be assigned as the label of an object.
        /// </summary>
        ERROR_INVALID_LABEL = 1299, // 0x00000513
        /// <summary>
        /// Not all privileges or groups referenced are assigned to the caller.
        /// </summary>
        ERROR_NOT_ALL_ASSIGNED = 1300, // 0x00000514
        /// <summary>
        /// Some mapping between account names and security IDs was not done.
        /// </summary>
        ERROR_SOME_NOT_MAPPED = 1301, // 0x00000515
        /// <summary>
        /// No system quota limits are specifically set for this account.
        /// </summary>
        ERROR_NO_QUOTAS_FOR_ACCOUNT = 1302, // 0x00000516
        /// <summary>
        /// No encryption key is available. A well-known encryption key was returned.
        /// </summary>
        ERROR_LOCAL_USER_SESSION_KEY = 1303, // 0x00000517
        /// <summary>
        /// The password is too complex to be converted to a LAN Manager password. The LAN Manager password returned is a NULL string.
        /// </summary>
        ERROR_NULL_LM_PASSWORD = 1304, // 0x00000518
        /// <summary>The revision level is unknown.</summary>
        ERROR_UNKNOWN_REVISION = 1305, // 0x00000519
        /// <summary>Indicates two revision levels are incompatible.</summary>
        ERROR_REVISION_MISMATCH = 1306, // 0x0000051A
        /// <summary>
        /// This security ID may not be assigned as the owner of this object.
        /// </summary>
        ERROR_INVALID_OWNER = 1307, // 0x0000051B
        /// <summary>
        /// This security ID may not be assigned as the primary group of an object.
        /// </summary>
        ERROR_INVALID_PRIMARY_GROUP = 1308, // 0x0000051C
        /// <summary>
        /// An attempt has been made to operate on an impersonation token by a thread that is not currently impersonating a client.
        /// </summary>
        ERROR_NO_IMPERSONATION_TOKEN = 1309, // 0x0000051D
        /// <summary>The group may not be disabled.</summary>
        ERROR_CANT_DISABLE_MANDATORY = 1310, // 0x0000051E
        /// <summary>
        /// There are currently no logon servers available to service the logon request.
        /// </summary>
        ERROR_NO_LOGON_SERVERS = 1311, // 0x0000051F
        /// <summary>
        /// A specified logon session does not exist. It may already have been terminated.
        /// </summary>
        ERROR_NO_SUCH_LOGON_SESSION = 1312, // 0x00000520
        /// <summary>A specified privilege does not exist.</summary>
        ERROR_NO_SUCH_PRIVILEGE = 1313, // 0x00000521
        /// <summary>A required privilege is not held by the client.</summary>
        ERROR_PRIVILEGE_NOT_HELD = 1314, // 0x00000522
        /// <summary>
        /// The name provided is not a properly formed account name.
        /// </summary>
        ERROR_INVALID_ACCOUNT_NAME = 1315, // 0x00000523
        /// <summary>The specified account already exists.</summary>
        ERROR_USER_EXISTS = 1316, // 0x00000524
        /// <summary>The specified account does not exist.</summary>
        ERROR_NO_SUCH_USER = 1317, // 0x00000525
        /// <summary>The specified group already exists.</summary>
        ERROR_GROUP_EXISTS = 1318, // 0x00000526
        /// <summary>The specified group does not exist.</summary>
        ERROR_NO_SUCH_GROUP = 1319, // 0x00000527
        /// <summary>
        /// Either the specified user account is already a member of the specified group, or the specified group cannot be deleted because it contains a member.
        /// </summary>
        ERROR_MEMBER_IN_GROUP = 1320, // 0x00000528
        /// <summary>
        /// The specified user account is not a member of the specified group account.
        /// </summary>
        ERROR_MEMBER_NOT_IN_GROUP = 1321, // 0x00000529
        /// <summary>
        /// This operation is disallowed as it could result in an administration account being disabled, deleted or unable to log on.
        /// </summary>
        ERROR_LAST_ADMIN = 1322, // 0x0000052A
        /// <summary>
        /// Unable to update the password. The value provided as the current password is incorrect.
        /// </summary>
        ERROR_WRONG_PASSWORD = 1323, // 0x0000052B
        /// <summary>
        /// Unable to update the password. The value provided for the new password contains values that are not allowed in passwords.
        /// </summary>
        ERROR_ILL_FORMED_PASSWORD = 1324, // 0x0000052C
        /// <summary>
        /// Unable to update the password. The value provided for the new password does not meet the length, complexity, or history requirements of the domain.
        /// </summary>
        ERROR_PASSWORD_RESTRICTION = 1325, // 0x0000052D
        /// <summary>The user name or password is incorrect.</summary>
        ERROR_LOGON_FAILURE = 1326, // 0x0000052E
        /// <summary>
        /// Account restrictions are preventing this user from signing in. For example: blank passwords aren't allowed, sign-in times are limited, or a policy restriction has been enforced.
        /// </summary>
        ERROR_ACCOUNT_RESTRICTION = 1327, // 0x0000052F
        /// <summary>
        /// Your account has time restrictions that keep you from signing in right now.
        /// </summary>
        ERROR_INVALID_LOGON_HOURS = 1328, // 0x00000530
        /// <summary>This user isn't allowed to sign in to this computer.</summary>
        ERROR_INVALID_WORKSTATION = 1329, // 0x00000531
        /// <summary>The password for this account has expired.</summary>
        ERROR_PASSWORD_EXPIRED = 1330, // 0x00000532
        /// <summary>
        /// This user can't sign in because this account is currently disabled.
        /// </summary>
        ERROR_ACCOUNT_DISABLED = 1331, // 0x00000533
        /// <summary>
        /// No mapping between account names and security IDs was done.
        /// </summary>
        ERROR_NONE_MAPPED = 1332, // 0x00000534
        /// <summary>
        /// Too many local user identifiers (LUIDs) were requested at one time.
        /// </summary>
        ERROR_TOO_MANY_LUIDS_REQUESTED = 1333, // 0x00000535
        /// <summary>No more local user identifiers (LUIDs) are available.</summary>
        ERROR_LUIDS_EXHAUSTED = 1334, // 0x00000536
        /// <summary>
        /// The subauthority part of a security ID is invalid for this particular use.
        /// </summary>
        ERROR_INVALID_SUB_AUTHORITY = 1335, // 0x00000537
        /// <summary>The access control list (ACL) structure is invalid.</summary>
        ERROR_INVALID_ACL = 1336, // 0x00000538
        /// <summary>The security ID structure is invalid.</summary>
        ERROR_INVALID_SID = 1337, // 0x00000539
        /// <summary>The security descriptor structure is invalid.</summary>
        ERROR_INVALID_SECURITY_DESCR = 1338, // 0x0000053A
        /// <summary>
        /// The inherited access control list (ACL) or access control entry (ACE) could not be built.
        /// </summary>
        ERROR_BAD_INHERITANCE_ACL = 1340, // 0x0000053C
        /// <summary>The server is currently disabled.</summary>
        ERROR_SERVER_DISABLED = 1341, // 0x0000053D
        /// <summary>The server is currently enabled.</summary>
        ERROR_SERVER_NOT_DISABLED = 1342, // 0x0000053E
        /// <summary>
        /// The value provided was an invalid value for an identifier authority.
        /// </summary>
        ERROR_INVALID_ID_AUTHORITY = 1343, // 0x0000053F
        /// <summary>
        /// No more memory is available for security information updates.
        /// </summary>
        ERROR_ALLOTTED_SPACE_EXCEEDED = 1344, // 0x00000540
        /// <summary>
        /// The specified attributes are invalid, or incompatible with the attributes for the group as a whole.
        /// </summary>
        ERROR_INVALID_GROUP_ATTRIBUTES = 1345, // 0x00000541
        /// <summary>
        /// Either a required impersonation level was not provided, or the provided impersonation level is invalid.
        /// </summary>
        ERROR_BAD_IMPERSONATION_LEVEL = 1346, // 0x00000542
        /// <summary>Cannot open an anonymous level security token.</summary>
        ERROR_CANT_OPEN_ANONYMOUS = 1347, // 0x00000543
        /// <summary>
        /// The validation information class requested was invalid.
        /// </summary>
        ERROR_BAD_VALIDATION_CLASS = 1348, // 0x00000544
        /// <summary>
        /// The type of the token is inappropriate for its attempted use.
        /// </summary>
        ERROR_BAD_TOKEN_TYPE = 1349, // 0x00000545
        /// <summary>
        /// Unable to perform a security operation on an object that has no associated security.
        /// </summary>
        ERROR_NO_SECURITY_ON_OBJECT = 1350, // 0x00000546
        /// <summary>
        /// Configuration information could not be read from the domain controller, either because the machine is unavailable, or access has been denied.
        /// </summary>
        ERROR_CANT_ACCESS_DOMAIN_INFO = 1351, // 0x00000547
        /// <summary>
        /// The security account manager (SAM) or local security authority (LSA) server was in the wrong state to perform the security operation.
        /// </summary>
        ERROR_INVALID_SERVER_STATE = 1352, // 0x00000548
        /// <summary>
        /// The domain was in the wrong state to perform the security operation.
        /// </summary>
        ERROR_INVALID_DOMAIN_STATE = 1353, // 0x00000549
        /// <summary>
        /// This operation is only allowed for the Primary Domain Controller of the domain.
        /// </summary>
        ERROR_INVALID_DOMAIN_ROLE = 1354, // 0x0000054A
        /// <summary>
        /// The specified domain either does not exist or could not be contacted.
        /// </summary>
        ERROR_NO_SUCH_DOMAIN = 1355, // 0x0000054B
        /// <summary>The specified domain already exists.</summary>
        ERROR_DOMAIN_EXISTS = 1356, // 0x0000054C
        /// <summary>
        /// An attempt was made to exceed the limit on the number of domains per server.
        /// </summary>
        ERROR_DOMAIN_LIMIT_EXCEEDED = 1357, // 0x0000054D
        /// <summary>
        /// Unable to complete the requested operation because of either a catastrophic media failure or a data structure corruption on the disk.
        /// </summary>
        ERROR_INTERNAL_DB_CORRUPTION = 1358, // 0x0000054E
        /// <summary>An internal error occurred.</summary>
        ERROR_INTERNAL_ERROR = 1359, // 0x0000054F
        /// <summary>
        /// Generic access types were contained in an access mask which should already be mapped to nongeneric types.
        /// </summary>
        ERROR_GENERIC_NOT_MAPPED = 1360, // 0x00000550
        /// <summary>
        /// A security descriptor is not in the right format (absolute or self-relative).
        /// </summary>
        ERROR_BAD_DESCRIPTOR_FORMAT = 1361, // 0x00000551
        /// <summary>
        /// The requested action is restricted for use by logon processes only. The calling process has not registered as a logon process.
        /// </summary>
        ERROR_NOT_LOGON_PROCESS = 1362, // 0x00000552
        /// <summary>
        /// Cannot start a new logon session with an ID that is already in use.
        /// </summary>
        ERROR_LOGON_SESSION_EXISTS = 1363, // 0x00000553
        /// <summary>A specified authentication package is unknown.</summary>
        ERROR_NO_SUCH_PACKAGE = 1364, // 0x00000554
        /// <summary>
        /// The logon session is not in a state that is consistent with the requested operation.
        /// </summary>
        ERROR_BAD_LOGON_SESSION_STATE = 1365, // 0x00000555
        /// <summary>The logon session ID is already in use.</summary>
        ERROR_LOGON_SESSION_COLLISION = 1366, // 0x00000556
        /// <summary>
        /// A logon request contained an invalid logon type value.
        /// </summary>
        ERROR_INVALID_LOGON_TYPE = 1367, // 0x00000557
        /// <summary>
        /// Unable to impersonate using a named pipe until data has been read from that pipe.
        /// </summary>
        ERROR_CANNOT_IMPERSONATE = 1368, // 0x00000558
        /// <summary>
        /// The transaction state of a registry subtree is incompatible with the requested operation.
        /// </summary>
        ERROR_RXACT_INVALID_STATE = 1369, // 0x00000559
        /// <summary>
        /// An internal security database corruption has been encountered.
        /// </summary>
        ERROR_RXACT_COMMIT_FAILURE = 1370, // 0x0000055A
        /// <summary>Cannot perform this operation on built-in accounts.</summary>
        ERROR_SPECIAL_ACCOUNT = 1371, // 0x0000055B
        /// <summary>
        /// Cannot perform this operation on this built-in special group.
        /// </summary>
        ERROR_SPECIAL_GROUP = 1372, // 0x0000055C
        /// <summary>
        /// Cannot perform this operation on this built-in special user.
        /// </summary>
        ERROR_SPECIAL_USER = 1373, // 0x0000055D
        /// <summary>
        /// The user cannot be removed from a group because the group is currently the user's primary group.
        /// </summary>
        ERROR_MEMBERS_PRIMARY_GROUP = 1374, // 0x0000055E
        /// <summary>The token is already in use as a primary token.</summary>
        ERROR_TOKEN_ALREADY_IN_USE = 1375, // 0x0000055F
        /// <summary>The specified local group does not exist.</summary>
        ERROR_NO_SUCH_ALIAS = 1376, // 0x00000560
        /// <summary>
        /// The specified account name is not a member of the group.
        /// </summary>
        ERROR_MEMBER_NOT_IN_ALIAS = 1377, // 0x00000561
        /// <summary>
        /// The specified account name is already a member of the group.
        /// </summary>
        ERROR_MEMBER_IN_ALIAS = 1378, // 0x00000562
        /// <summary>The specified local group already exists.</summary>
        ERROR_ALIAS_EXISTS = 1379, // 0x00000563
        /// <summary>
        /// Logon failure: the user has not been granted the requested logon type at this computer.
        /// </summary>
        ERROR_LOGON_NOT_GRANTED = 1380, // 0x00000564
        /// <summary>
        /// The maximum number of secrets that may be stored in a single system has been exceeded.
        /// </summary>
        ERROR_TOO_MANY_SECRETS = 1381, // 0x00000565
        /// <summary>
        /// The length of a secret exceeds the maximum length allowed.
        /// </summary>
        ERROR_SECRET_TOO_LONG = 1382, // 0x00000566
        /// <summary>
        /// The local security authority database contains an internal inconsistency.
        /// </summary>
        ERROR_INTERNAL_DB_ERROR = 1383, // 0x00000567
        /// <summary>
        /// During a logon attempt, the user's security context accumulated too many security IDs.
        /// </summary>
        ERROR_TOO_MANY_CONTEXT_IDS = 1384, // 0x00000568
        /// <summary>
        /// Logon failure: the user has not been granted the requested logon type at this computer.
        /// </summary>
        ERROR_LOGON_TYPE_NOT_GRANTED = 1385, // 0x00000569
        /// <summary>
        /// A cross-encrypted password is necessary to change a user password.
        /// </summary>
        ERROR_NT_CROSS_ENCRYPTION_REQUIRED = 1386, // 0x0000056A
        /// <summary>
        /// A member could not be added to or removed from the local group because the member does not exist.
        /// </summary>
        ERROR_NO_SUCH_MEMBER = 1387, // 0x0000056B
        /// <summary>
        /// A new member could not be added to a local group because the member has the wrong account type.
        /// </summary>
        ERROR_INVALID_MEMBER = 1388, // 0x0000056C
        /// <summary>Too many security IDs have been specified.</summary>
        ERROR_TOO_MANY_SIDS = 1389, // 0x0000056D
        /// <summary>
        /// A cross-encrypted password is necessary to change this user password.
        /// </summary>
        ERROR_LM_CROSS_ENCRYPTION_REQUIRED = 1390, // 0x0000056E
        /// <summary>Indicates an ACL contains no inheritable components.</summary>
        ERROR_NO_INHERITANCE = 1391, // 0x0000056F
        /// <summary>The file or directory is corrupted and unreadable.</summary>
        ERROR_FILE_CORRUPT = 1392, // 0x00000570
        /// <summary>The disk structure is corrupted and unreadable.</summary>
        ERROR_DISK_CORRUPT = 1393, // 0x00000571
        /// <summary>
        /// There is no user session key for the specified logon session.
        /// </summary>
        ERROR_NO_USER_SESSION_KEY = 1394, // 0x00000572
        /// <summary>
        /// The service being accessed is licensed for a particular number of connections. No more connections can be made to the service at this time because there are already as many connections as the service can accept.
        /// </summary>
        ERROR_LICENSE_QUOTA_EXCEEDED = 1395, // 0x00000573
        /// <summary>The target account name is incorrect.</summary>
        ERROR_WRONG_TARGET_NAME = 1396, // 0x00000574
        /// <summary>
        /// Mutual Authentication failed. The server's password is out of date at the domain controller.
        /// </summary>
        ERROR_MUTUAL_AUTH_FAILED = 1397, // 0x00000575
        /// <summary>
        /// There is a time and/or date difference between the client and server.
        /// </summary>
        ERROR_TIME_SKEW = 1398, // 0x00000576
        /// <summary>
        /// This operation cannot be performed on the current domain.
        /// </summary>
        ERROR_CURRENT_DOMAIN_NOT_ALLOWED = 1399, // 0x00000577
        /// <summary>Invalid window handle.</summary>
        ERROR_INVALID_WINDOW_HANDLE = 1400, // 0x00000578
        /// <summary>Invalid menu handle.</summary>
        ERROR_INVALID_MENU_HANDLE = 1401, // 0x00000579
        /// <summary>Invalid cursor handle.</summary>
        ERROR_INVALID_CURSOR_HANDLE = 1402, // 0x0000057A
        /// <summary>Invalid accelerator table handle.</summary>
        ERROR_INVALID_ACCEL_HANDLE = 1403, // 0x0000057B
        /// <summary>Invalid hook handle.</summary>
        ERROR_INVALID_HOOK_HANDLE = 1404, // 0x0000057C
        /// <summary>
        /// Invalid handle to a multiple-window position structure.
        /// </summary>
        ERROR_INVALID_DWP_HANDLE = 1405, // 0x0000057D
        /// <summary>Cannot create a top-level child window.</summary>
        ERROR_TLW_WITH_WSCHILD = 1406, // 0x0000057E
        /// <summary>Cannot find window class.</summary>
        ERROR_CANNOT_FIND_WND_CLASS = 1407, // 0x0000057F
        /// <summary>Invalid window; it belongs to other thread.</summary>
        ERROR_WINDOW_OF_OTHER_THREAD = 1408, // 0x00000580
        /// <summary>Hot key is already registered.</summary>
        ERROR_HOTKEY_ALREADY_REGISTERED = 1409, // 0x00000581
        /// <summary>Class already exists.</summary>
        ERROR_CLASS_ALREADY_EXISTS = 1410, // 0x00000582
        /// <summary>Class does not exist.</summary>
        ERROR_CLASS_DOES_NOT_EXIST = 1411, // 0x00000583
        /// <summary>Class still has open windows.</summary>
        ERROR_CLASS_HAS_WINDOWS = 1412, // 0x00000584
        /// <summary>Invalid index.</summary>
        ERROR_INVALID_INDEX = 1413, // 0x00000585
        /// <summary>Invalid icon handle.</summary>
        ERROR_INVALID_ICON_HANDLE = 1414, // 0x00000586
        /// <summary>Using private DIALOG window words.</summary>
        ERROR_PRIVATE_DIALOG_INDEX = 1415, // 0x00000587
        /// <summary>The list box identifier was not found.</summary>
        ERROR_LISTBOX_ID_NOT_FOUND = 1416, // 0x00000588
        /// <summary>No wildcards were found.</summary>
        ERROR_NO_WILDCARD_CHARACTERS = 1417, // 0x00000589
        /// <summary>Thread does not have a clipboard open.</summary>
        ERROR_CLIPBOARD_NOT_OPEN = 1418, // 0x0000058A
        /// <summary>Hot key is not registered.</summary>
        ERROR_HOTKEY_NOT_REGISTERED = 1419, // 0x0000058B
        /// <summary>The window is not a valid dialog window.</summary>
        ERROR_WINDOW_NOT_DIALOG = 1420, // 0x0000058C
        /// <summary>Control ID not found.</summary>
        ERROR_CONTROL_ID_NOT_FOUND = 1421, // 0x0000058D
        /// <summary>
        /// Invalid message for a combo box because it does not have an edit control.
        /// </summary>
        ERROR_INVALID_COMBOBOX_MESSAGE = 1422, // 0x0000058E
        /// <summary>The window is not a combo box.</summary>
        ERROR_WINDOW_NOT_COMBOBOX = 1423, // 0x0000058F
        /// <summary>Height must be less than 256.</summary>
        ERROR_INVALID_EDIT_HEIGHT = 1424, // 0x00000590
        /// <summary>Invalid device context (DC) handle.</summary>
        ERROR_DC_NOT_FOUND = 1425, // 0x00000591
        /// <summary>Invalid hook procedure type.</summary>
        ERROR_INVALID_HOOK_FILTER = 1426, // 0x00000592
        /// <summary>Invalid hook procedure.</summary>
        ERROR_INVALID_FILTER_PROC = 1427, // 0x00000593
        /// <summary>Cannot set nonlocal hook without a module handle.</summary>
        ERROR_HOOK_NEEDS_HMOD = 1428, // 0x00000594
        /// <summary>This hook procedure can only be set globally.</summary>
        ERROR_GLOBAL_ONLY_HOOK = 1429, // 0x00000595
        /// <summary>The journal hook procedure is already installed.</summary>
        ERROR_JOURNAL_HOOK_SET = 1430, // 0x00000596
        /// <summary>The hook procedure is not installed.</summary>
        ERROR_HOOK_NOT_INSTALLED = 1431, // 0x00000597
        /// <summary>Invalid message for single-selection list box.</summary>
        ERROR_INVALID_LB_MESSAGE = 1432, // 0x00000598
        /// <summary>LB_SETCOUNT sent to non-lazy list box.</summary>
        ERROR_SETCOUNT_ON_BAD_LB = 1433, // 0x00000599
        /// <summary>This list box does not support tab stops.</summary>
        ERROR_LB_WITHOUT_TABSTOPS = 1434, // 0x0000059A
        /// <summary>Cannot destroy object created by another thread.</summary>
        ERROR_DESTROY_OBJECT_OF_OTHER_THREAD = 1435, // 0x0000059B
        /// <summary>Child windows cannot have menus.</summary>
        ERROR_CHILD_WINDOW_MENU = 1436, // 0x0000059C
        /// <summary>The window does not have a system menu.</summary>
        ERROR_NO_SYSTEM_MENU = 1437, // 0x0000059D
        /// <summary>Invalid message box style.</summary>
        ERROR_INVALID_MSGBOX_STYLE = 1438, // 0x0000059E
        /// <summary>Invalid system-wide (SPI_*) parameter.</summary>
        ERROR_INVALID_SPI_VALUE = 1439, // 0x0000059F
        /// <summary>Screen already locked.</summary>
        ERROR_SCREEN_ALREADY_LOCKED = 1440, // 0x000005A0
        /// <summary>
        /// All handles to windows in a multiple-window position structure must have the same parent.
        /// </summary>
        ERROR_HWNDS_HAVE_DIFF_PARENT = 1441, // 0x000005A1
        /// <summary>The window is not a child window.</summary>
        ERROR_NOT_CHILD_WINDOW = 1442, // 0x000005A2
        /// <summary>Invalid GW_* command.</summary>
        ERROR_INVALID_GW_COMMAND = 1443, // 0x000005A3
        /// <summary>Invalid thread identifier.</summary>
        ERROR_INVALID_THREAD_ID = 1444, // 0x000005A4
        /// <summary>
        /// Cannot process a message from a window that is not a multiple document interface (MDI) window.
        /// </summary>
        ERROR_NON_MDICHILD_WINDOW = 1445, // 0x000005A5
        /// <summary>Popup menu already active.</summary>
        ERROR_POPUP_ALREADY_ACTIVE = 1446, // 0x000005A6
        /// <summary>The window does not have scroll bars.</summary>
        ERROR_NO_SCROLLBARS = 1447, // 0x000005A7
        /// <summary>Scroll bar range cannot be greater than MAXLONG.</summary>
        ERROR_INVALID_SCROLLBAR_RANGE = 1448, // 0x000005A8
        /// <summary>
        /// Cannot show or remove the window in the way specified.
        /// </summary>
        ERROR_INVALID_SHOWWIN_COMMAND = 1449, // 0x000005A9
        /// <summary>
        /// Insufficient system resources exist to complete the requested service.
        /// </summary>
        ERROR_NO_SYSTEM_RESOURCES = 1450, // 0x000005AA
        /// <summary>
        /// Insufficient system resources exist to complete the requested service.
        /// </summary>
        ERROR_NONPAGED_SYSTEM_RESOURCES = 1451, // 0x000005AB
        /// <summary>
        /// Insufficient system resources exist to complete the requested service.
        /// </summary>
        ERROR_PAGED_SYSTEM_RESOURCES = 1452, // 0x000005AC
        /// <summary>Insufficient quota to complete the requested service.</summary>
        ERROR_WORKING_SET_QUOTA = 1453, // 0x000005AD
        /// <summary>Insufficient quota to complete the requested service.</summary>
        ERROR_PAGEFILE_QUOTA = 1454, // 0x000005AE
        /// <summary>
        /// The paging file is too small for this operation to complete.
        /// </summary>
        ERROR_COMMITMENT_LIMIT = 1455, // 0x000005AF
        /// <summary>A menu item was not found.</summary>
        ERROR_MENU_ITEM_NOT_FOUND = 1456, // 0x000005B0
        /// <summary>Invalid keyboard layout handle.</summary>
        ERROR_INVALID_KEYBOARD_HANDLE = 1457, // 0x000005B1
        /// <summary>Hook type not allowed.</summary>
        ERROR_HOOK_TYPE_NOT_ALLOWED = 1458, // 0x000005B2
        /// <summary>
        /// This operation requires an interactive window station.
        /// </summary>
        ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION = 1459, // 0x000005B3
        /// <summary>
        /// This operation returned because the timeout period expired.
        /// </summary>
        ERROR_TIMEOUT = 1460, // 0x000005B4
        /// <summary>Invalid monitor handle.</summary>
        ERROR_INVALID_MONITOR_HANDLE = 1461, // 0x000005B5
        /// <summary>Incorrect size argument.</summary>
        ERROR_INCORRECT_SIZE = 1462, // 0x000005B6
        /// <summary>
        /// The symbolic link cannot be followed because its type is disabled.
        /// </summary>
        ERROR_SYMLINK_CLASS_DISABLED = 1463, // 0x000005B7
        /// <summary>
        /// This application does not support the current operation on symbolic links.
        /// </summary>
        ERROR_SYMLINK_NOT_SUPPORTED = 1464, // 0x000005B8
        /// <summary>Windows was unable to parse the requested XML data.</summary>
        ERROR_XML_PARSE_ERROR = 1465, // 0x000005B9
        /// <summary>
        /// An error was encountered while processing an XML digital signature.
        /// </summary>
        ERROR_XMLDSIG_ERROR = 1466, // 0x000005BA
        /// <summary>This application must be restarted.</summary>
        ERROR_RESTART_APPLICATION = 1467, // 0x000005BB
        /// <summary>
        /// The caller made the connection request in the wrong routing compartment.
        /// </summary>
        ERROR_WRONG_COMPARTMENT = 1468, // 0x000005BC
        /// <summary>
        /// There was an AuthIP failure when attempting to connect to the remote host.
        /// </summary>
        ERROR_AUTHIP_FAILURE = 1469, // 0x000005BD
        /// <summary>
        /// Insufficient NVRAM resources exist to complete the requested service. A reboot might be required.
        /// </summary>
        ERROR_NO_NVRAM_RESOURCES = 1470, // 0x000005BE
        /// <summary>
        /// Unable to finish the requested operation because the specified process is not a GUI process.
        /// </summary>
        ERROR_NOT_GUI_PROCESS = 1471, // 0x000005BF
        /// <summary>The event log file is corrupted.</summary>
        ERROR_EVENTLOG_FILE_CORRUPT = 1500, // 0x000005DC
        /// <summary>
        /// No event log file could be opened, so the event logging service did not start.
        /// </summary>
        ERROR_EVENTLOG_CANT_START = 1501, // 0x000005DD
        /// <summary>The event log file is full.</summary>
        ERROR_LOG_FILE_FULL = 1502, // 0x000005DE
        /// <summary>
        /// The event log file has changed between read operations.
        /// </summary>
        ERROR_EVENTLOG_FILE_CHANGED = 1503, // 0x000005DF
        /// <summary>The specified task name is invalid.</summary>
        ERROR_INVALID_TASK_NAME = 1550, // 0x0000060E
        /// <summary>The specified task index is invalid.</summary>
        ERROR_INVALID_TASK_INDEX = 1551, // 0x0000060F
        /// <summary>The specified thread is already joining a task.</summary>
        ERROR_THREAD_ALREADY_IN_TASK = 1552, // 0x00000610
        /// <summary>
        /// The Windows Installer Service could not be accessed. This can occur if the Windows Installer is not correctly installed. Contact your support personnel for assistance.
        /// </summary>
        ERROR_INSTALL_SERVICE_FAILURE = 1601, // 0x00000641
        /// <summary>User cancelled installation.</summary>
        ERROR_INSTALL_USEREXIT = 1602, // 0x00000642
        /// <summary>Fatal error during installation.</summary>
        ERROR_INSTALL_FAILURE = 1603, // 0x00000643
        /// <summary>Installation suspended, incomplete.</summary>
        ERROR_INSTALL_SUSPEND = 1604, // 0x00000644
        /// <summary>
        /// This action is only valid for products that are currently installed.
        /// </summary>
        ERROR_UNKNOWN_PRODUCT = 1605, // 0x00000645
        /// <summary>Feature ID not registered.</summary>
        ERROR_UNKNOWN_FEATURE = 1606, // 0x00000646
        /// <summary>Component ID not registered.</summary>
        ERROR_UNKNOWN_COMPONENT = 1607, // 0x00000647
        /// <summary>Unknown property.</summary>
        ERROR_UNKNOWN_PROPERTY = 1608, // 0x00000648
        /// <summary>Handle is in an invalid state.</summary>
        ERROR_INVALID_HANDLE_STATE = 1609, // 0x00000649
        /// <summary>
        /// The configuration data for this product is corrupt. Contact your support personnel.
        /// </summary>
        ERROR_BAD_CONFIGURATION = 1610, // 0x0000064A
        /// <summary>Component qualifier not present.</summary>
        ERROR_INDEX_ABSENT = 1611, // 0x0000064B
        /// <summary>
        /// The installation source for this product is not available. Verify that the source exists and that you can access it.
        /// </summary>
        ERROR_INSTALL_SOURCE_ABSENT = 1612, // 0x0000064C
        /// <summary>
        /// This installation package cannot be installed by the Windows Installer service. You must install a Windows service pack that contains a newer version of the Windows Installer service.
        /// </summary>
        ERROR_INSTALL_PACKAGE_VERSION = 1613, // 0x0000064D
        /// <summary>Product is uninstalled.</summary>
        ERROR_PRODUCT_UNINSTALLED = 1614, // 0x0000064E
        /// <summary>SQL query syntax invalid or unsupported.</summary>
        ERROR_BAD_QUERY_SYNTAX = 1615, // 0x0000064F
        /// <summary>Record field does not exist.</summary>
        ERROR_INVALID_FIELD = 1616, // 0x00000650
        /// <summary>The device has been removed.</summary>
        ERROR_DEVICE_REMOVED = 1617, // 0x00000651
        /// <summary>
        /// Another installation is already in progress. Complete that installation before proceeding with this install.
        /// </summary>
        ERROR_INSTALL_ALREADY_RUNNING = 1618, // 0x00000652
        /// <summary>
        /// This installation package could not be opened. Verify that the package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer package.
        /// </summary>
        ERROR_INSTALL_PACKAGE_OPEN_FAILED = 1619, // 0x00000653
        /// <summary>
        /// This installation package could not be opened. Contact the application vendor to verify that this is a valid Windows Installer package.
        /// </summary>
        ERROR_INSTALL_PACKAGE_INVALID = 1620, // 0x00000654
        /// <summary>
        /// There was an error starting the Windows Installer service user interface. Contact your support personnel.
        /// </summary>
        ERROR_INSTALL_UI_FAILURE = 1621, // 0x00000655
        /// <summary>
        /// Error opening installation log file. Verify that the specified log file location exists and that you can write to it.
        /// </summary>
        ERROR_INSTALL_LOG_FAILURE = 1622, // 0x00000656
        /// <summary>
        /// The language of this installation package is not supported by your system.
        /// </summary>
        ERROR_INSTALL_LANGUAGE_UNSUPPORTED = 1623, // 0x00000657
        /// <summary>
        /// Error applying transforms. Verify that the specified transform paths are valid.
        /// </summary>
        ERROR_INSTALL_TRANSFORM_FAILURE = 1624, // 0x00000658
        /// <summary>
        /// This installation is forbidden by system policy. Contact your system administrator.
        /// </summary>
        ERROR_INSTALL_PACKAGE_REJECTED = 1625, // 0x00000659
        /// <summary>Function could not be executed.</summary>
        ERROR_FUNCTION_NOT_CALLED = 1626, // 0x0000065A
        /// <summary>Function failed during execution.</summary>
        ERROR_FUNCTION_FAILED = 1627, // 0x0000065B
        /// <summary>Invalid or unknown table specified.</summary>
        ERROR_INVALID_TABLE = 1628, // 0x0000065C
        /// <summary>Data supplied is of wrong type.</summary>
        ERROR_DATATYPE_MISMATCH = 1629, // 0x0000065D
        /// <summary>Data of this type is not supported.</summary>
        ERROR_UNSUPPORTED_TYPE = 1630, // 0x0000065E
        /// <summary>
        /// The Windows Installer service failed to start. Contact your support personnel.
        /// </summary>
        ERROR_CREATE_FAILED = 1631, // 0x0000065F
        /// <summary>
        /// The Temp folder is on a drive that is full or is inaccessible. Free up space on the drive or verify that you have write permission on the Temp folder.
        /// </summary>
        ERROR_INSTALL_TEMP_UNWRITABLE = 1632, // 0x00000660
        /// <summary>
        /// This installation package is not supported by this processor type. Contact your product vendor.
        /// </summary>
        ERROR_INSTALL_PLATFORM_UNSUPPORTED = 1633, // 0x00000661
        /// <summary>Component not used on this computer.</summary>
        ERROR_INSTALL_NOTUSED = 1634, // 0x00000662
        /// <summary>
        /// This update package could not be opened. Verify that the update package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer update package.
        /// </summary>
        ERROR_PATCH_PACKAGE_OPEN_FAILED = 1635, // 0x00000663
        /// <summary>
        /// This update package could not be opened. Contact the application vendor to verify that this is a valid Windows Installer update package.
        /// </summary>
        ERROR_PATCH_PACKAGE_INVALID = 1636, // 0x00000664
        /// <summary>
        /// This update package cannot be processed by the Windows Installer service. You must install a Windows service pack that contains a newer version of the Windows Installer service.
        /// </summary>
        ERROR_PATCH_PACKAGE_UNSUPPORTED = 1637, // 0x00000665
        /// <summary>
        /// Another version of this product is already installed. Installation of this version cannot continue. To configure or remove the existing version of this product, use Add/Remove Programs on the Control Panel.
        /// </summary>
        ERROR_PRODUCT_VERSION = 1638, // 0x00000666
        /// <summary>
        /// Invalid command line argument. Consult the Windows Installer SDK for detailed command line help.
        /// </summary>
        ERROR_INVALID_COMMAND_LINE = 1639, // 0x00000667
        /// <summary>
        /// Only administrators have permission to add, remove, or configure server software during a Terminal services remote session. If you want to install or configure software on the server, contact your network administrator.
        /// </summary>
        ERROR_INSTALL_REMOTE_DISALLOWED = 1640, // 0x00000668
        /// <summary>
        /// The requested operation completed successfully. The system will be restarted so the changes can take effect.
        /// </summary>
        ERROR_SUCCESS_REBOOT_INITIATED = 1641, // 0x00000669
        /// <summary>
        /// The upgrade cannot be installed by the Windows Installer service because the program to be upgraded may be missing, or the upgrade may update a different version of the program. Verify that the program to be upgraded exists on your computer and that you have the correct upgrade.
        /// </summary>
        ERROR_PATCH_TARGET_NOT_FOUND = 1642, // 0x0000066A
        /// <summary>
        /// The update package is not permitted by software restriction policy.
        /// </summary>
        ERROR_PATCH_PACKAGE_REJECTED = 1643, // 0x0000066B
        /// <summary>
        /// One or more customizations are not permitted by software restriction policy.
        /// </summary>
        ERROR_INSTALL_TRANSFORM_REJECTED = 1644, // 0x0000066C
        /// <summary>
        /// The Windows Installer does not permit installation from a Remote Desktop Connection.
        /// </summary>
        ERROR_INSTALL_REMOTE_PROHIBITED = 1645, // 0x0000066D
        /// <summary>
        /// Uninstallation of the update package is not supported.
        /// </summary>
        ERROR_PATCH_REMOVAL_UNSUPPORTED = 1646, // 0x0000066E
        /// <summary>The update is not applied to this product.</summary>
        ERROR_UNKNOWN_PATCH = 1647, // 0x0000066F
        /// <summary>
        /// No valid sequence could be found for the set of updates.
        /// </summary>
        ERROR_PATCH_NO_SEQUENCE = 1648, // 0x00000670
        /// <summary>Update removal was disallowed by policy.</summary>
        ERROR_PATCH_REMOVAL_DISALLOWED = 1649, // 0x00000671
        /// <summary>The XML update data is invalid.</summary>
        ERROR_INVALID_PATCH_XML = 1650, // 0x00000672
        /// <summary>
        /// Windows Installer does not permit updating of managed advertised products. At least one feature of the product must be installed before applying the update.
        /// </summary>
        ERROR_PATCH_MANAGED_ADVERTISED_PRODUCT = 1651, // 0x00000673
        /// <summary>
        /// The Windows Installer service is not accessible in Safe Mode. Please try again when your computer is not in Safe Mode or you can use System Restore to return your machine to a previous good state.
        /// </summary>
        ERROR_INSTALL_SERVICE_SAFEBOOT = 1652, // 0x00000674
        /// <summary>
        /// A fail fast exception occurred. Exception handlers will not be invoked and the process will be terminated immediately.
        /// </summary>
        ERROR_FAIL_FAST_EXCEPTION = 1653, // 0x00000675
        /// <summary>
        /// The app that you are trying to run is not supported on this version of Windows.
        /// </summary>
        ERROR_INSTALL_REJECTED = 1654, // 0x00000676
        /// <summary>The string binding is invalid.</summary>
        RPC_S_INVALID_STRING_BINDING = 1700, // 0x000006A4
        /// <summary>The binding handle is not the correct type.</summary>
        RPC_S_WRONG_KIND_OF_BINDING = 1701, // 0x000006A5
        /// <summary>The binding handle is invalid.</summary>
        RPC_S_INVALID_BINDING = 1702, // 0x000006A6
        /// <summary>The RPC protocol sequence is not supported.</summary>
        RPC_S_PROTSEQ_NOT_SUPPORTED = 1703, // 0x000006A7
        /// <summary>The RPC protocol sequence is invalid.</summary>
        RPC_S_INVALID_RPC_PROTSEQ = 1704, // 0x000006A8
        /// <summary>
        /// The string universal unique identifier (UUID) is invalid.
        /// </summary>
        RPC_S_INVALID_STRING_UUID = 1705, // 0x000006A9
        /// <summary>The endpoint format is invalid.</summary>
        RPC_S_INVALID_ENDPOINT_FORMAT = 1706, // 0x000006AA
        /// <summary>The network address is invalid.</summary>
        RPC_S_INVALID_NET_ADDR = 1707, // 0x000006AB
        /// <summary>No endpoint was found.</summary>
        RPC_S_NO_ENDPOINT_FOUND = 1708, // 0x000006AC
        /// <summary>The timeout value is invalid.</summary>
        RPC_S_INVALID_TIMEOUT = 1709, // 0x000006AD
        /// <summary>
        /// The object universal unique identifier (UUID) was not found.
        /// </summary>
        RPC_S_OBJECT_NOT_FOUND = 1710, // 0x000006AE
        /// <summary>
        /// The object universal unique identifier (UUID) has already been registered.
        /// </summary>
        RPC_S_ALREADY_REGISTERED = 1711, // 0x000006AF
        /// <summary>
        /// The type universal unique identifier (UUID) has already been registered.
        /// </summary>
        RPC_S_TYPE_ALREADY_REGISTERED = 1712, // 0x000006B0
        /// <summary>The RPC server is already listening.</summary>
        RPC_S_ALREADY_LISTENING = 1713, // 0x000006B1
        /// <summary>No protocol sequences have been registered.</summary>
        RPC_S_NO_PROTSEQS_REGISTERED = 1714, // 0x000006B2
        /// <summary>The RPC server is not listening.</summary>
        RPC_S_NOT_LISTENING = 1715, // 0x000006B3
        /// <summary>The manager type is unknown.</summary>
        RPC_S_UNKNOWN_MGR_TYPE = 1716, // 0x000006B4
        /// <summary>The interface is unknown.</summary>
        RPC_S_UNKNOWN_IF = 1717, // 0x000006B5
        /// <summary>There are no bindings.</summary>
        RPC_S_NO_BINDINGS = 1718, // 0x000006B6
        /// <summary>There are no protocol sequences.</summary>
        RPC_S_NO_PROTSEQS = 1719, // 0x000006B7
        /// <summary>The endpoint cannot be created.</summary>
        RPC_S_CANT_CREATE_ENDPOINT = 1720, // 0x000006B8
        /// <summary>
        /// Not enough resources are available to complete this operation.
        /// </summary>
        RPC_S_OUT_OF_RESOURCES = 1721, // 0x000006B9
        /// <summary>The RPC server is unavailable.</summary>
        RPC_S_SERVER_UNAVAILABLE = 1722, // 0x000006BA
        /// <summary>
        /// The RPC server is too busy to complete this operation.
        /// </summary>
        RPC_S_SERVER_TOO_BUSY = 1723, // 0x000006BB
        /// <summary>The network options are invalid.</summary>
        RPC_S_INVALID_NETWORK_OPTIONS = 1724, // 0x000006BC
        /// <summary>
        /// There are no remote procedure calls active on this thread.
        /// </summary>
        RPC_S_NO_CALL_ACTIVE = 1725, // 0x000006BD
        /// <summary>The remote procedure call failed.</summary>
        RPC_S_CALL_FAILED = 1726, // 0x000006BE
        /// <summary>The remote procedure call failed and did not execute.</summary>
        RPC_S_CALL_FAILED_DNE = 1727, // 0x000006BF
        /// <summary>
        /// A remote procedure call (RPC) protocol error occurred.
        /// </summary>
        RPC_S_PROTOCOL_ERROR = 1728, // 0x000006C0
        /// <summary>Access to the HTTP proxy is denied.</summary>
        RPC_S_PROXY_ACCESS_DENIED = 1729, // 0x000006C1
        /// <summary>
        /// The transfer syntax is not supported by the RPC server.
        /// </summary>
        RPC_S_UNSUPPORTED_TRANS_SYN = 1730, // 0x000006C2
        /// <summary>
        /// The universal unique identifier (UUID) type is not supported.
        /// </summary>
        RPC_S_UNSUPPORTED_TYPE = 1732, // 0x000006C4
        /// <summary>The tag is invalid.</summary>
        RPC_S_INVALID_TAG = 1733, // 0x000006C5
        /// <summary>The array bounds are invalid.</summary>
        RPC_S_INVALID_BOUND = 1734, // 0x000006C6
        /// <summary>The binding does not contain an entry name.</summary>
        RPC_S_NO_ENTRY_NAME = 1735, // 0x000006C7
        /// <summary>The name syntax is invalid.</summary>
        RPC_S_INVALID_NAME_SYNTAX = 1736, // 0x000006C8
        /// <summary>The name syntax is not supported.</summary>
        RPC_S_UNSUPPORTED_NAME_SYNTAX = 1737, // 0x000006C9
        /// <summary>
        /// No network address is available to use to construct a universal unique identifier (UUID).
        /// </summary>
        RPC_S_UUID_NO_ADDRESS = 1739, // 0x000006CB
        /// <summary>The endpoint is a duplicate.</summary>
        RPC_S_DUPLICATE_ENDPOINT = 1740, // 0x000006CC
        /// <summary>The authentication type is unknown.</summary>
        RPC_S_UNKNOWN_AUTHN_TYPE = 1741, // 0x000006CD
        /// <summary>The maximum number of calls is too small.</summary>
        RPC_S_MAX_CALLS_TOO_SMALL = 1742, // 0x000006CE
        /// <summary>The string is too long.</summary>
        RPC_S_STRING_TOO_LONG = 1743, // 0x000006CF
        /// <summary>The RPC protocol sequence was not found.</summary>
        RPC_S_PROTSEQ_NOT_FOUND = 1744, // 0x000006D0
        /// <summary>The procedure number is out of range.</summary>
        RPC_S_PROCNUM_OUT_OF_RANGE = 1745, // 0x000006D1
        /// <summary>
        /// The binding does not contain any authentication information.
        /// </summary>
        RPC_S_BINDING_HAS_NO_AUTH = 1746, // 0x000006D2
        /// <summary>The authentication service is unknown.</summary>
        RPC_S_UNKNOWN_AUTHN_SERVICE = 1747, // 0x000006D3
        /// <summary>The authentication level is unknown.</summary>
        RPC_S_UNKNOWN_AUTHN_LEVEL = 1748, // 0x000006D4
        /// <summary>The security context is invalid.</summary>
        RPC_S_INVALID_AUTH_IDENTITY = 1749, // 0x000006D5
        /// <summary>The authorization service is unknown.</summary>
        RPC_S_UNKNOWN_AUTHZ_SERVICE = 1750, // 0x000006D6
        /// <summary>The entry is invalid.</summary>
        EPT_S_INVALID_ENTRY = 1751, // 0x000006D7
        /// <summary>The server endpoint cannot perform the operation.</summary>
        EPT_S_CANT_PERFORM_OP = 1752, // 0x000006D8
        /// <summary>
        /// There are no more endpoints available from the endpoint mapper.
        /// </summary>
        EPT_S_NOT_REGISTERED = 1753, // 0x000006D9
        /// <summary>No interfaces have been exported.</summary>
        RPC_S_NOTHING_TO_EXPORT = 1754, // 0x000006DA
        /// <summary>The entry name is incomplete.</summary>
        RPC_S_INCOMPLETE_NAME = 1755, // 0x000006DB
        /// <summary>The version option is invalid.</summary>
        RPC_S_INVALID_VERS_OPTION = 1756, // 0x000006DC
        /// <summary>There are no more members.</summary>
        RPC_S_NO_MORE_MEMBERS = 1757, // 0x000006DD
        /// <summary>There is nothing to unexport.</summary>
        RPC_S_NOT_ALL_OBJS_UNEXPORTED = 1758, // 0x000006DE
        /// <summary>The interface was not found.</summary>
        RPC_S_INTERFACE_NOT_FOUND = 1759, // 0x000006DF
        /// <summary>The entry already exists.</summary>
        RPC_S_ENTRY_ALREADY_EXISTS = 1760, // 0x000006E0
        /// <summary>The entry is not found.</summary>
        RPC_S_ENTRY_NOT_FOUND = 1761, // 0x000006E1
        /// <summary>The name service is unavailable.</summary>
        RPC_S_NAME_SERVICE_UNAVAILABLE = 1762, // 0x000006E2
        /// <summary>The network address family is invalid.</summary>
        RPC_S_INVALID_NAF_ID = 1763, // 0x000006E3
        /// <summary>The requested operation is not supported.</summary>
        RPC_S_CANNOT_SUPPORT = 1764, // 0x000006E4
        /// <summary>
        /// No security context is available to allow impersonation.
        /// </summary>
        RPC_S_NO_CONTEXT_AVAILABLE = 1765, // 0x000006E5
        /// <summary>
        /// An internal error occurred in a remote procedure call (RPC).
        /// </summary>
        RPC_S_INTERNAL_ERROR = 1766, // 0x000006E6
        /// <summary>The RPC server attempted an integer division by zero.</summary>
        RPC_S_ZERO_DIVIDE = 1767, // 0x000006E7
        /// <summary>An addressing error occurred in the RPC server.</summary>
        RPC_S_ADDRESS_ERROR = 1768, // 0x000006E8
        /// <summary>
        /// A floating-point operation at the RPC server caused a division by zero.
        /// </summary>
        RPC_S_FP_DIV_ZERO = 1769, // 0x000006E9
        /// <summary>
        /// A floating-point underflow occurred at the RPC server.
        /// </summary>
        RPC_S_FP_UNDERFLOW = 1770, // 0x000006EA
        /// <summary>A floating-point overflow occurred at the RPC server.</summary>
        RPC_S_FP_OVERFLOW = 1771, // 0x000006EB
        /// <summary>
        /// The list of RPC servers available for the binding of auto handles has been exhausted.
        /// </summary>
        RPC_X_NO_MORE_ENTRIES = 1772, // 0x000006EC
        /// <summary>Unable to open the character translation table file.</summary>
        RPC_X_SS_CHAR_TRANS_OPEN_FAIL = 1773, // 0x000006ED
        /// <summary>
        /// The file containing the character translation table has fewer than 512 bytes.
        /// </summary>
        RPC_X_SS_CHAR_TRANS_SHORT_FILE = 1774, // 0x000006EE
        /// <summary>
        /// A null context handle was passed from the client to the host during a remote procedure call.
        /// </summary>
        RPC_X_SS_IN_NULL_CONTEXT = 1775, // 0x000006EF
        /// <summary>
        /// The context handle changed during a remote procedure call.
        /// </summary>
        RPC_X_SS_CONTEXT_DAMAGED = 1777, // 0x000006F1
        /// <summary>
        /// The binding handles passed to a remote procedure call do not match.
        /// </summary>
        RPC_X_SS_HANDLES_MISMATCH = 1778, // 0x000006F2
        /// <summary>
        /// The stub is unable to get the remote procedure call handle.
        /// </summary>
        RPC_X_SS_CANNOT_GET_CALL_HANDLE = 1779, // 0x000006F3
        /// <summary>A null reference pointer was passed to the stub.</summary>
        RPC_X_NULL_REF_POINTER = 1780, // 0x000006F4
        /// <summary>The enumeration value is out of range.</summary>
        RPC_X_ENUM_VALUE_OUT_OF_RANGE = 1781, // 0x000006F5
        /// <summary>The byte count is too small.</summary>
        RPC_X_BYTE_COUNT_TOO_SMALL = 1782, // 0x000006F6
        /// <summary>The stub received bad data.</summary>
        RPC_X_BAD_STUB_DATA = 1783, // 0x000006F7
        /// <summary>
        /// The supplied user buffer is not valid for the requested operation.
        /// </summary>
        ERROR_INVALID_USER_BUFFER = 1784, // 0x000006F8
        /// <summary>
        /// The disk media is not recognized. It may not be formatted.
        /// </summary>
        ERROR_UNRECOGNIZED_MEDIA = 1785, // 0x000006F9
        /// <summary>The workstation does not have a trust secret.</summary>
        ERROR_NO_TRUST_LSA_SECRET = 1786, // 0x000006FA
        /// <summary>
        /// The security database on the server does not have a computer account for this workstation trust relationship.
        /// </summary>
        ERROR_NO_TRUST_SAM_ACCOUNT = 1787, // 0x000006FB
        /// <summary>
        /// The trust relationship between the primary domain and the trusted domain failed.
        /// </summary>
        ERROR_TRUSTED_DOMAIN_FAILURE = 1788, // 0x000006FC
        /// <summary>
        /// The trust relationship between this workstation and the primary domain failed.
        /// </summary>
        ERROR_TRUSTED_RELATIONSHIP_FAILURE = 1789, // 0x000006FD
        /// <summary>The network logon failed.</summary>
        ERROR_TRUST_FAILURE = 1790, // 0x000006FE
        /// <summary>
        /// A remote procedure call is already in progress for this thread.
        /// </summary>
        RPC_S_CALL_IN_PROGRESS = 1791, // 0x000006FF
        /// <summary>
        /// An attempt was made to logon, but the network logon service was not started.
        /// </summary>
        ERROR_NETLOGON_NOT_STARTED = 1792, // 0x00000700
        /// <summary>The user's account has expired.</summary>
        ERROR_ACCOUNT_EXPIRED = 1793, // 0x00000701
        /// <summary>The redirector is in use and cannot be unloaded.</summary>
        ERROR_REDIRECTOR_HAS_OPEN_HANDLES = 1794, // 0x00000702
        /// <summary>The specified printer driver is already installed.</summary>
        ERROR_PRINTER_DRIVER_ALREADY_INSTALLED = 1795, // 0x00000703
        /// <summary>The specified port is unknown.</summary>
        ERROR_UNKNOWN_PORT = 1796, // 0x00000704
        /// <summary>The printer driver is unknown.</summary>
        ERROR_UNKNOWN_PRINTER_DRIVER = 1797, // 0x00000705
        /// <summary>The print processor is unknown.</summary>
        ERROR_UNKNOWN_PRINTPROCESSOR = 1798, // 0x00000706
        /// <summary>The specified separator file is invalid.</summary>
        ERROR_INVALID_SEPARATOR_FILE = 1799, // 0x00000707
        /// <summary>The specified priority is invalid.</summary>
        ERROR_INVALID_PRIORITY = 1800, // 0x00000708
        /// <summary>The printer name is invalid.</summary>
        ERROR_INVALID_PRINTER_NAME = 1801, // 0x00000709
        /// <summary>The printer already exists.</summary>
        ERROR_PRINTER_ALREADY_EXISTS = 1802, // 0x0000070A
        /// <summary>The printer command is invalid.</summary>
        ERROR_INVALID_PRINTER_COMMAND = 1803, // 0x0000070B
        /// <summary>The specified datatype is invalid.</summary>
        ERROR_INVALID_DATATYPE = 1804, // 0x0000070C
        /// <summary>The environment specified is invalid.</summary>
        ERROR_INVALID_ENVIRONMENT = 1805, // 0x0000070D
        /// <summary>There are no more bindings.</summary>
        RPC_S_NO_MORE_BINDINGS = 1806, // 0x0000070E
        /// <summary>
        /// The account used is an interdomain trust account. Use your global user account or local user account to access this server.
        /// </summary>
        ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT = 1807, // 0x0000070F
        /// <summary>
        /// The account used is a computer account. Use your global user account or local user account to access this server.
        /// </summary>
        ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT = 1808, // 0x00000710
        /// <summary>
        /// The account used is a server trust account. Use your global user account or local user account to access this server.
        /// </summary>
        ERROR_NOLOGON_SERVER_TRUST_ACCOUNT = 1809, // 0x00000711
        /// <summary>
        /// The name or security ID (SID) of the domain specified is inconsistent with the trust information for that domain.
        /// </summary>
        ERROR_DOMAIN_TRUST_INCONSISTENT = 1810, // 0x00000712
        /// <summary>The server is in use and cannot be unloaded.</summary>
        ERROR_SERVER_HAS_OPEN_HANDLES = 1811, // 0x00000713
        /// <summary>
        /// The specified image file did not contain a resource section.
        /// </summary>
        ERROR_RESOURCE_DATA_NOT_FOUND = 1812, // 0x00000714
        /// <summary>
        /// The specified resource type cannot be found in the image file.
        /// </summary>
        ERROR_RESOURCE_TYPE_NOT_FOUND = 1813, // 0x00000715
        /// <summary>
        /// The specified resource name cannot be found in the image file.
        /// </summary>
        ERROR_RESOURCE_NAME_NOT_FOUND = 1814, // 0x00000716
        /// <summary>
        /// The specified resource language ID cannot be found in the image file.
        /// </summary>
        ERROR_RESOURCE_LANG_NOT_FOUND = 1815, // 0x00000717
        /// <summary>
        /// Not enough quota is available to process this command.
        /// </summary>
        ERROR_NOT_ENOUGH_QUOTA = 1816, // 0x00000718
        /// <summary>No interfaces have been registered.</summary>
        RPC_S_NO_INTERFACES = 1817, // 0x00000719
        /// <summary>The remote procedure call was cancelled.</summary>
        RPC_S_CALL_CANCELLED = 1818, // 0x0000071A
        /// <summary>
        /// The binding handle does not contain all required information.
        /// </summary>
        RPC_S_BINDING_INCOMPLETE = 1819, // 0x0000071B
        /// <summary>
        /// A communications failure occurred during a remote procedure call.
        /// </summary>
        RPC_S_COMM_FAILURE = 1820, // 0x0000071C
        /// <summary>The requested authentication level is not supported.</summary>
        RPC_S_UNSUPPORTED_AUTHN_LEVEL = 1821, // 0x0000071D
        /// <summary>No principal name registered.</summary>
        RPC_S_NO_PRINC_NAME = 1822, // 0x0000071E
        /// <summary>
        /// The error specified is not a valid Windows RPC error code.
        /// </summary>
        RPC_S_NOT_RPC_ERROR = 1823, // 0x0000071F
        /// <summary>
        /// A UUID that is valid only on this computer has been allocated.
        /// </summary>
        RPC_S_UUID_LOCAL_ONLY = 1824, // 0x00000720
        /// <summary>A security package specific error occurred.</summary>
        RPC_S_SEC_PKG_ERROR = 1825, // 0x00000721
        /// <summary>Thread is not canceled.</summary>
        RPC_S_NOT_CANCELLED = 1826, // 0x00000722
        /// <summary>Invalid operation on the encoding/decoding handle.</summary>
        RPC_X_INVALID_ES_ACTION = 1827, // 0x00000723
        /// <summary>Incompatible version of the serializing package.</summary>
        RPC_X_WRONG_ES_VERSION = 1828, // 0x00000724
        /// <summary>Incompatible version of the RPC stub.</summary>
        RPC_X_WRONG_STUB_VERSION = 1829, // 0x00000725
        /// <summary>The RPC pipe object is invalid or corrupted.</summary>
        RPC_X_INVALID_PIPE_OBJECT = 1830, // 0x00000726
        /// <summary>
        /// An invalid operation was attempted on an RPC pipe object.
        /// </summary>
        RPC_X_WRONG_PIPE_ORDER = 1831, // 0x00000727
        /// <summary>Unsupported RPC pipe version.</summary>
        RPC_X_WRONG_PIPE_VERSION = 1832, // 0x00000728
        /// <summary>
        /// HTTP proxy server rejected the connection because the cookie authentication failed.
        /// </summary>
        RPC_S_COOKIE_AUTH_FAILED = 1833, // 0x00000729
        /// <summary>The group member was not found.</summary>
        RPC_S_GROUP_MEMBER_NOT_FOUND = 1898, // 0x0000076A
        /// <summary>
        /// The endpoint mapper database entry could not be created.
        /// </summary>
        EPT_S_CANT_CREATE = 1899, // 0x0000076B
        /// <summary>
        /// The object universal unique identifier (UUID) is the nil UUID.
        /// </summary>
        RPC_S_INVALID_OBJECT = 1900, // 0x0000076C
        /// <summary>The specified time is invalid.</summary>
        ERROR_INVALID_TIME = 1901, // 0x0000076D
        /// <summary>The specified form name is invalid.</summary>
        ERROR_INVALID_FORM_NAME = 1902, // 0x0000076E
        /// <summary>The specified form size is invalid.</summary>
        ERROR_INVALID_FORM_SIZE = 1903, // 0x0000076F
        /// <summary>
        /// The specified printer handle is already being waited on.
        /// </summary>
        ERROR_ALREADY_WAITING = 1904, // 0x00000770
        /// <summary>The specified printer has been deleted.</summary>
        ERROR_PRINTER_DELETED = 1905, // 0x00000771
        /// <summary>The state of the printer is invalid.</summary>
        ERROR_INVALID_PRINTER_STATE = 1906, // 0x00000772
        /// <summary>
        /// The user's password must be changed before signing in.
        /// </summary>
        ERROR_PASSWORD_MUST_CHANGE = 1907, // 0x00000773
        /// <summary>Could not find the domain controller for this domain.</summary>
        ERROR_DOMAIN_CONTROLLER_NOT_FOUND = 1908, // 0x00000774
        /// <summary>
        /// The referenced account is currently locked out and may not be logged on to.
        /// </summary>
        ERROR_ACCOUNT_LOCKED_OUT = 1909, // 0x00000775
        /// <summary>The object exporter specified was not found.</summary>
        OR_INVALID_OXID = 1910, // 0x00000776
        /// <summary>The object specified was not found.</summary>
        OR_INVALID_OID = 1911, // 0x00000777
        /// <summary>The object resolver set specified was not found.</summary>
        OR_INVALID_SET = 1912, // 0x00000778
        /// <summary>Some data remains to be sent in the request buffer.</summary>
        RPC_S_SEND_INCOMPLETE = 1913, // 0x00000779
        /// <summary>Invalid asynchronous remote procedure call handle.</summary>
        RPC_S_INVALID_ASYNC_HANDLE = 1914, // 0x0000077A
        /// <summary>
        /// Invalid asynchronous RPC call handle for this operation.
        /// </summary>
        RPC_S_INVALID_ASYNC_CALL = 1915, // 0x0000077B
        /// <summary>The RPC pipe object has already been closed.</summary>
        RPC_X_PIPE_CLOSED = 1916, // 0x0000077C
        /// <summary>
        /// The RPC call completed before all pipes were processed.
        /// </summary>
        RPC_X_PIPE_DISCIPLINE_ERROR = 1917, // 0x0000077D
        /// <summary>No more data is available from the RPC pipe.</summary>
        RPC_X_PIPE_EMPTY = 1918, // 0x0000077E
        /// <summary>No site name is available for this machine.</summary>
        ERROR_NO_SITENAME = 1919, // 0x0000077F
        /// <summary>The file cannot be accessed by the system.</summary>
        ERROR_CANT_ACCESS_FILE = 1920, // 0x00000780
        /// <summary>
        /// The name of the file cannot be resolved by the system.
        /// </summary>
        ERROR_CANT_RESOLVE_FILENAME = 1921, // 0x00000781
        /// <summary>The entry is not of the expected type.</summary>
        RPC_S_ENTRY_TYPE_MISMATCH = 1922, // 0x00000782
        /// <summary>
        /// Not all object UUIDs could be exported to the specified entry.
        /// </summary>
        RPC_S_NOT_ALL_OBJS_EXPORTED = 1923, // 0x00000783
        /// <summary>
        /// Interface could not be exported to the specified entry.
        /// </summary>
        RPC_S_INTERFACE_NOT_EXPORTED = 1924, // 0x00000784
        /// <summary>The specified profile entry could not be added.</summary>
        RPC_S_PROFILE_NOT_ADDED = 1925, // 0x00000785
        /// <summary>The specified profile element could not be added.</summary>
        RPC_S_PRF_ELT_NOT_ADDED = 1926, // 0x00000786
        /// <summary>The specified profile element could not be removed.</summary>
        RPC_S_PRF_ELT_NOT_REMOVED = 1927, // 0x00000787
        /// <summary>The group element could not be added.</summary>
        RPC_S_GRP_ELT_NOT_ADDED = 1928, // 0x00000788
        /// <summary>The group element could not be removed.</summary>
        RPC_S_GRP_ELT_NOT_REMOVED = 1929, // 0x00000789
        /// <summary>
        /// The printer driver is not compatible with a policy enabled on your computer that blocks NT 4.0 drivers.
        /// </summary>
        ERROR_KM_DRIVER_BLOCKED = 1930, // 0x0000078A
        /// <summary>The context has expired and can no longer be used.</summary>
        ERROR_CONTEXT_EXPIRED = 1931, // 0x0000078B
        /// <summary>
        /// The current user's delegated trust creation quota has been exceeded.
        /// </summary>
        ERROR_PER_USER_TRUST_QUOTA_EXCEEDED = 1932, // 0x0000078C
        /// <summary>
        /// The total delegated trust creation quota has been exceeded.
        /// </summary>
        ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED = 1933, // 0x0000078D
        /// <summary>
        /// The current user's delegated trust deletion quota has been exceeded.
        /// </summary>
        ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED = 1934, // 0x0000078E
        /// <summary>
        /// The computer you are signing into is protected by an authentication firewall. The specified account is not allowed to authenticate to the computer.
        /// </summary>
        ERROR_AUTHENTICATION_FIREWALL_FAILED = 1935, // 0x0000078F
        /// <summary>
        /// Remote connections to the Print Spooler are blocked by a policy set on your machine.
        /// </summary>
        ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED = 1936, // 0x00000790
        /// <summary>
        /// Authentication failed because NTLM authentication has been disabled.
        /// </summary>
        ERROR_NTLM_BLOCKED = 1937, // 0x00000791
        /// <summary>
        /// Logon Failure: EAS policy requires that the user change their password before this operation can be performed.
        /// </summary>
        ERROR_PASSWORD_CHANGE_REQUIRED = 1938, // 0x00000792
        /// <summary>The pixel format is invalid.</summary>
        ERROR_INVALID_PIXEL_FORMAT = 2000, // 0x000007D0
        /// <summary>The specified driver is invalid.</summary>
        ERROR_BAD_DRIVER = 2001, // 0x000007D1
        /// <summary>
        /// The window style or class attribute is invalid for this operation.
        /// </summary>
        ERROR_INVALID_WINDOW_STYLE = 2002, // 0x000007D2
        /// <summary>The requested metafile operation is not supported.</summary>
        ERROR_METAFILE_NOT_SUPPORTED = 2003, // 0x000007D3
        /// <summary>
        /// The requested transformation operation is not supported.
        /// </summary>
        ERROR_TRANSFORM_NOT_SUPPORTED = 2004, // 0x000007D4
        /// <summary>The requested clipping operation is not supported.</summary>
        ERROR_CLIPPING_NOT_SUPPORTED = 2005, // 0x000007D5
        /// <summary>The specified color management module is invalid.</summary>
        ERROR_INVALID_CMM = 2010, // 0x000007DA
        /// <summary>The specified color profile is invalid.</summary>
        ERROR_INVALID_PROFILE = 2011, // 0x000007DB
        /// <summary>The specified tag was not found.</summary>
        ERROR_TAG_NOT_FOUND = 2012, // 0x000007DC
        /// <summary>A required tag is not present.</summary>
        ERROR_TAG_NOT_PRESENT = 2013, // 0x000007DD
        /// <summary>The specified tag is already present.</summary>
        ERROR_DUPLICATE_TAG = 2014, // 0x000007DE
        /// <summary>
        /// The specified color profile is not associated with the specified device.
        /// </summary>
        ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE = 2015, // 0x000007DF
        /// <summary>The specified color profile was not found.</summary>
        ERROR_PROFILE_NOT_FOUND = 2016, // 0x000007E0
        /// <summary>The specified color space is invalid.</summary>
        ERROR_INVALID_COLORSPACE = 2017, // 0x000007E1
        /// <summary>Image Color Management is not enabled.</summary>
        ERROR_ICM_NOT_ENABLED = 2018, // 0x000007E2
        /// <summary>
        /// There was an error while deleting the color transform.
        /// </summary>
        ERROR_DELETING_ICM_XFORM = 2019, // 0x000007E3
        /// <summary>The specified color transform is invalid.</summary>
        ERROR_INVALID_TRANSFORM = 2020, // 0x000007E4
        /// <summary>
        /// The specified transform does not match the bitmap's color space.
        /// </summary>
        ERROR_COLORSPACE_MISMATCH = 2021, // 0x000007E5
        /// <summary>
        /// The specified named color index is not present in the profile.
        /// </summary>
        ERROR_INVALID_COLORINDEX = 2022, // 0x000007E6
        /// <summary>
        /// The specified profile is intended for a device of a different type than the specified device.
        /// </summary>
        ERROR_PROFILE_DOES_NOT_MATCH_DEVICE = 2023, // 0x000007E7
        /// <summary>
        /// The network connection was made successfully, but the user had to be prompted for a password other than the one originally specified.
        /// </summary>
        ERROR_CONNECTED_OTHER_PASSWORD = 2108, // 0x0000083C
        /// <summary>
        /// The network connection was made successfully using default credentials.
        /// </summary>
        ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT = 2109, // 0x0000083D
        /// <summary>The specified username is invalid.</summary>
        ERROR_BAD_USERNAME = 2202, // 0x0000089A
        /// <summary>This network connection does not exist.</summary>
        ERROR_NOT_CONNECTED = 2250, // 0x000008CA
        /// <summary>
        /// This network connection has files open or requests pending.
        /// </summary>
        ERROR_OPEN_FILES = 2401, // 0x00000961
        /// <summary>Active connections still exist.</summary>
        ERROR_ACTIVE_CONNECTIONS = 2402, // 0x00000962
        /// <summary>
        /// The device is in use by an active process and cannot be disconnected.
        /// </summary>
        ERROR_DEVICE_IN_USE = 2404, // 0x00000964
        /// <summary>The specified print monitor is unknown.</summary>
        ERROR_UNKNOWN_PRINT_MONITOR = 3000, // 0x00000BB8
        /// <summary>The specified printer driver is currently in use.</summary>
        ERROR_PRINTER_DRIVER_IN_USE = 3001, // 0x00000BB9
        /// <summary>The spool file was not found.</summary>
        ERROR_SPOOL_FILE_NOT_FOUND = 3002, // 0x00000BBA
        /// <summary>A StartDocPrinter call was not issued.</summary>
        ERROR_SPL_NO_STARTDOC = 3003, // 0x00000BBB
        /// <summary>An AddJob call was not issued.</summary>
        ERROR_SPL_NO_ADDJOB = 3004, // 0x00000BBC
        /// <summary>
        /// The specified print processor has already been installed.
        /// </summary>
        ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED = 3005, // 0x00000BBD
        /// <summary>
        /// The specified print monitor has already been installed.
        /// </summary>
        ERROR_PRINT_MONITOR_ALREADY_INSTALLED = 3006, // 0x00000BBE
        /// <summary>
        /// The specified print monitor does not have the required functions.
        /// </summary>
        ERROR_INVALID_PRINT_MONITOR = 3007, // 0x00000BBF
        /// <summary>The specified print monitor is currently in use.</summary>
        ERROR_PRINT_MONITOR_IN_USE = 3008, // 0x00000BC0
        /// <summary>
        /// The requested operation is not allowed when there are jobs queued to the printer.
        /// </summary>
        ERROR_PRINTER_HAS_JOBS_QUEUED = 3009, // 0x00000BC1
        /// <summary>
        /// The requested operation is successful. Changes will not be effective until the system is rebooted.
        /// </summary>
        ERROR_SUCCESS_REBOOT_REQUIRED = 3010, // 0x00000BC2
        /// <summary>
        /// The requested operation is successful. Changes will not be effective until the service is restarted.
        /// </summary>
        ERROR_SUCCESS_RESTART_REQUIRED = 3011, // 0x00000BC3
        /// <summary>No printers were found.</summary>
        ERROR_PRINTER_NOT_FOUND = 3012, // 0x00000BC4
        /// <summary>The printer driver is known to be unreliable.</summary>
        ERROR_PRINTER_DRIVER_WARNED = 3013, // 0x00000BC5
        /// <summary>The printer driver is known to harm the system.</summary>
        ERROR_PRINTER_DRIVER_BLOCKED = 3014, // 0x00000BC6
        /// <summary>
        /// The specified printer driver package is currently in use.
        /// </summary>
        ERROR_PRINTER_DRIVER_PACKAGE_IN_USE = 3015, // 0x00000BC7
        /// <summary>
        /// Unable to find a core driver package that is required by the printer driver package.
        /// </summary>
        ERROR_CORE_DRIVER_PACKAGE_NOT_FOUND = 3016, // 0x00000BC8
        /// <summary>
        /// The requested operation failed. A system reboot is required to roll back changes made.
        /// </summary>
        ERROR_FAIL_REBOOT_REQUIRED = 3017, // 0x00000BC9
        /// <summary>
        /// The requested operation failed. A system reboot has been initiated to roll back changes made.
        /// </summary>
        ERROR_FAIL_REBOOT_INITIATED = 3018, // 0x00000BCA
        /// <summary>
        /// The specified printer driver was not found on the system and needs to be downloaded.
        /// </summary>
        ERROR_PRINTER_DRIVER_DOWNLOAD_NEEDED = 3019, // 0x00000BCB
        /// <summary>
        /// The requested print job has failed to print. A print system update requires the job to be resubmitted.
        /// </summary>
        ERROR_PRINT_JOB_RESTART_REQUIRED = 3020, // 0x00000BCC
        /// <summary>
        /// The printer driver does not contain a valid manifest, or contains too many manifests.
        /// </summary>
        ERROR_INVALID_PRINTER_DRIVER_MANIFEST = 3021, // 0x00000BCD
        /// <summary>The specified printer cannot be shared.</summary>
        ERROR_PRINTER_NOT_SHAREABLE = 3022, // 0x00000BCE
        /// <summary>The operation was paused.</summary>
        ERROR_REQUEST_PAUSED = 3050, // 0x00000BEA
        /// <summary>Reissue the given operation as a cached IO operation.</summary>
        ERROR_IO_REISSUE_AS_CACHED = 3950, // 0x00000F6E
        /// <summary>
        /// WINS encountered an error while processing the command.
        /// </summary>
        ERROR_WINS_INTERNAL = 4000, // 0x00000FA0
        /// <summary>The local WINS cannot be deleted.</summary>
        ERROR_CAN_NOT_DEL_LOCAL_WINS = 4001, // 0x00000FA1
        /// <summary>The importation from the file failed.</summary>
        ERROR_STATIC_INIT = 4002, // 0x00000FA2
        /// <summary>The backup failed. Was a full backup done before?</summary>
        ERROR_INC_BACKUP = 4003, // 0x00000FA3
        /// <summary>
        /// The backup failed. Check the directory to which you are backing the database.
        /// </summary>
        ERROR_FULL_BACKUP = 4004, // 0x00000FA4
        /// <summary>The name does not exist in the WINS database.</summary>
        ERROR_REC_NON_EXISTENT = 4005, // 0x00000FA5
        /// <summary>
        /// Replication with a nonconfigured partner is not allowed.
        /// </summary>
        ERROR_RPL_NOT_ALLOWED = 4006, // 0x00000FA6
        /// <summary>
        /// The version of the supplied content information is not supported.
        /// </summary>
        PEERDIST_ERROR_CONTENTINFO_VERSION_UNSUPPORTED = 4050, // 0x00000FD2
        /// <summary>The supplied content information is malformed.</summary>
        PEERDIST_ERROR_CANNOT_PARSE_CONTENTINFO = 4051, // 0x00000FD3
        /// <summary>
        /// The requested data cannot be found in local or peer caches.
        /// </summary>
        PEERDIST_ERROR_MISSING_DATA = 4052, // 0x00000FD4
        /// <summary>No more data is available or required.</summary>
        PEERDIST_ERROR_NO_MORE = 4053, // 0x00000FD5
        /// <summary>The supplied object has not been initialized.</summary>
        PEERDIST_ERROR_NOT_INITIALIZED = 4054, // 0x00000FD6
        /// <summary>The supplied object has already been initialized.</summary>
        PEERDIST_ERROR_ALREADY_INITIALIZED = 4055, // 0x00000FD7
        /// <summary>A shutdown operation is already in progress.</summary>
        PEERDIST_ERROR_SHUTDOWN_IN_PROGRESS = 4056, // 0x00000FD8
        /// <summary>The supplied object has already been invalidated.</summary>
        PEERDIST_ERROR_INVALIDATED = 4057, // 0x00000FD9
        /// <summary>An element already exists and was not replaced.</summary>
        PEERDIST_ERROR_ALREADY_EXISTS = 4058, // 0x00000FDA
        /// <summary>
        /// Can not cancel the requested operation as it has already been completed.
        /// </summary>
        PEERDIST_ERROR_OPERATION_NOTFOUND = 4059, // 0x00000FDB
        /// <summary>
        /// Can not perform the reqested operation because it has already been carried out.
        /// </summary>
        PEERDIST_ERROR_ALREADY_COMPLETED = 4060, // 0x00000FDC
        /// <summary>
        /// An operation accessed data beyond the bounds of valid data.
        /// </summary>
        PEERDIST_ERROR_OUT_OF_BOUNDS = 4061, // 0x00000FDD
        /// <summary>The requested version is not supported.</summary>
        PEERDIST_ERROR_VERSION_UNSUPPORTED = 4062, // 0x00000FDE
        /// <summary>A configuration value is invalid.</summary>
        PEERDIST_ERROR_INVALID_CONFIGURATION = 4063, // 0x00000FDF
        /// <summary>The SKU is not licensed.</summary>
        PEERDIST_ERROR_NOT_LICENSED = 4064, // 0x00000FE0
        /// <summary>
        /// PeerDist Service is still initializing and will be available shortly.
        /// </summary>
        PEERDIST_ERROR_SERVICE_UNAVAILABLE = 4065, // 0x00000FE1
        /// <summary>
        /// Communication with one or more computers will be temporarily blocked due to recent errors.
        /// </summary>
        PEERDIST_ERROR_TRUST_FAILURE = 4066, // 0x00000FE2
        /// <summary>
        /// The DHCP client has obtained an IP address that is already in use on the network. The local interface will be disabled until the DHCP client can obtain a new address.
        /// </summary>
        ERROR_DHCP_ADDRESS_CONFLICT = 4100, // 0x00001004
        /// <summary>
        /// The GUID passed was not recognized as valid by a WMI data provider.
        /// </summary>
        ERROR_WMI_GUID_NOT_FOUND = 4200, // 0x00001068
        /// <summary>
        /// The instance name passed was not recognized as valid by a WMI data provider.
        /// </summary>
        ERROR_WMI_INSTANCE_NOT_FOUND = 4201, // 0x00001069
        /// <summary>
        /// The data item ID passed was not recognized as valid by a WMI data provider.
        /// </summary>
        ERROR_WMI_ITEMID_NOT_FOUND = 4202, // 0x0000106A
        /// <summary>
        /// The WMI request could not be completed and should be retried.
        /// </summary>
        ERROR_WMI_TRY_AGAIN = 4203, // 0x0000106B
        /// <summary>The WMI data provider could not be located.</summary>
        ERROR_WMI_DP_NOT_FOUND = 4204, // 0x0000106C
        /// <summary>
        /// The WMI data provider references an instance set that has not been registered.
        /// </summary>
        ERROR_WMI_UNRESOLVED_INSTANCE_REF = 4205, // 0x0000106D
        /// <summary>
        /// The WMI data block or event notification has already been enabled.
        /// </summary>
        ERROR_WMI_ALREADY_ENABLED = 4206, // 0x0000106E
        /// <summary>The WMI data block is no longer available.</summary>
        ERROR_WMI_GUID_DISCONNECTED = 4207, // 0x0000106F
        /// <summary>The WMI data service is not available.</summary>
        ERROR_WMI_SERVER_UNAVAILABLE = 4208, // 0x00001070
        /// <summary>
        /// The WMI data provider failed to carry out the request.
        /// </summary>
        ERROR_WMI_DP_FAILED = 4209, // 0x00001071
        /// <summary>The WMI MOF information is not valid.</summary>
        ERROR_WMI_INVALID_MOF = 4210, // 0x00001072
        /// <summary>The WMI registration information is not valid.</summary>
        ERROR_WMI_INVALID_REGINFO = 4211, // 0x00001073
        /// <summary>
        /// The WMI data block or event notification has already been disabled.
        /// </summary>
        ERROR_WMI_ALREADY_DISABLED = 4212, // 0x00001074
        /// <summary>The WMI data item or data block is read only.</summary>
        ERROR_WMI_READ_ONLY = 4213, // 0x00001075
        /// <summary>The WMI data item or data block could not be changed.</summary>
        ERROR_WMI_SET_FAILURE = 4214, // 0x00001076
        /// <summary>
        /// This operation is only valid in the context of an app container.
        /// </summary>
        ERROR_NOT_APPCONTAINER = 4250, // 0x0000109A
        /// <summary>
        /// This application can only run in the context of an app container.
        /// </summary>
        ERROR_APPCONTAINER_REQUIRED = 4251, // 0x0000109B
        /// <summary>
        /// This functionality is not supported in the context of an app container.
        /// </summary>
        ERROR_NOT_SUPPORTED_IN_APPCONTAINER = 4252, // 0x0000109C
        /// <summary>
        /// The length of the SID supplied is not a valid length for app container SIDs.
        /// </summary>
        ERROR_INVALID_PACKAGE_SID_LENGTH = 4253, // 0x0000109D
        /// <summary>
        /// The media identifier does not represent a valid medium.
        /// </summary>
        ERROR_INVALID_MEDIA = 4300, // 0x000010CC
        /// <summary>
        /// The library identifier does not represent a valid library.
        /// </summary>
        ERROR_INVALID_LIBRARY = 4301, // 0x000010CD
        /// <summary>
        /// The media pool identifier does not represent a valid media pool.
        /// </summary>
        ERROR_INVALID_MEDIA_POOL = 4302, // 0x000010CE
        /// <summary>
        /// The drive and medium are not compatible or exist in different libraries.
        /// </summary>
        ERROR_DRIVE_MEDIA_MISMATCH = 4303, // 0x000010CF
        /// <summary>
        /// The medium currently exists in an offline library and must be online to perform this operation.
        /// </summary>
        ERROR_MEDIA_OFFLINE = 4304, // 0x000010D0
        /// <summary>
        /// The operation cannot be performed on an offline library.
        /// </summary>
        ERROR_LIBRARY_OFFLINE = 4305, // 0x000010D1
        /// <summary>The library, drive, or media pool is empty.</summary>
        ERROR_EMPTY = 4306, // 0x000010D2
        /// <summary>
        /// The library, drive, or media pool must be empty to perform this operation.
        /// </summary>
        ERROR_NOT_EMPTY = 4307, // 0x000010D3
        /// <summary>
        /// No media is currently available in this media pool or library.
        /// </summary>
        ERROR_MEDIA_UNAVAILABLE = 4308, // 0x000010D4
        /// <summary>A resource required for this operation is disabled.</summary>
        ERROR_RESOURCE_DISABLED = 4309, // 0x000010D5
        /// <summary>
        /// The media identifier does not represent a valid cleaner.
        /// </summary>
        ERROR_INVALID_CLEANER = 4310, // 0x000010D6
        /// <summary>
        /// The drive cannot be cleaned or does not support cleaning.
        /// </summary>
        ERROR_UNABLE_TO_CLEAN = 4311, // 0x000010D7
        /// <summary>
        /// The object identifier does not represent a valid object.
        /// </summary>
        ERROR_OBJECT_NOT_FOUND = 4312, // 0x000010D8
        /// <summary>Unable to read from or write to the database.</summary>
        ERROR_DATABASE_FAILURE = 4313, // 0x000010D9
        /// <summary>The database is full.</summary>
        ERROR_DATABASE_FULL = 4314, // 0x000010DA
        /// <summary>
        /// The medium is not compatible with the device or media pool.
        /// </summary>
        ERROR_MEDIA_INCOMPATIBLE = 4315, // 0x000010DB
        /// <summary>
        /// The resource required for this operation does not exist.
        /// </summary>
        ERROR_RESOURCE_NOT_PRESENT = 4316, // 0x000010DC
        /// <summary>The operation identifier is not valid.</summary>
        ERROR_INVALID_OPERATION = 4317, // 0x000010DD
        /// <summary>The media is not mounted or ready for use.</summary>
        ERROR_MEDIA_NOT_AVAILABLE = 4318, // 0x000010DE
        /// <summary>The device is not ready for use.</summary>
        ERROR_DEVICE_NOT_AVAILABLE = 4319, // 0x000010DF
        /// <summary>
        /// The operator or administrator has refused the request.
        /// </summary>
        ERROR_REQUEST_REFUSED = 4320, // 0x000010E0
        /// <summary>
        /// The drive identifier does not represent a valid drive.
        /// </summary>
        ERROR_INVALID_DRIVE_OBJECT = 4321, // 0x000010E1
        /// <summary>Library is full. No slot is available for use.</summary>
        ERROR_LIBRARY_FULL = 4322, // 0x000010E2
        /// <summary>The transport cannot access the medium.</summary>
        ERROR_MEDIUM_NOT_ACCESSIBLE = 4323, // 0x000010E3
        /// <summary>Unable to load the medium into the drive.</summary>
        ERROR_UNABLE_TO_LOAD_MEDIUM = 4324, // 0x000010E4
        /// <summary>Unable to retrieve the drive status.</summary>
        ERROR_UNABLE_TO_INVENTORY_DRIVE = 4325, // 0x000010E5
        /// <summary>Unable to retrieve the slot status.</summary>
        ERROR_UNABLE_TO_INVENTORY_SLOT = 4326, // 0x000010E6
        /// <summary>Unable to retrieve status about the transport.</summary>
        ERROR_UNABLE_TO_INVENTORY_TRANSPORT = 4327, // 0x000010E7
        /// <summary>
        /// Cannot use the transport because it is already in use.
        /// </summary>
        ERROR_TRANSPORT_FULL = 4328, // 0x000010E8
        /// <summary>Unable to open or close the inject/eject port.</summary>
        ERROR_CONTROLLING_IEPORT = 4329, // 0x000010E9
        /// <summary>Unable to eject the medium because it is in a drive.</summary>
        ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA = 4330, // 0x000010EA
        /// <summary>A cleaner slot is already reserved.</summary>
        ERROR_CLEANER_SLOT_SET = 4331, // 0x000010EB
        /// <summary>A cleaner slot is not reserved.</summary>
        ERROR_CLEANER_SLOT_NOT_SET = 4332, // 0x000010EC
        /// <summary>
        /// The cleaner cartridge has performed the maximum number of drive cleanings.
        /// </summary>
        ERROR_CLEANER_CARTRIDGE_SPENT = 4333, // 0x000010ED
        /// <summary>Unexpected on-medium identifier.</summary>
        ERROR_UNEXPECTED_OMID = 4334, // 0x000010EE
        /// <summary>
        /// The last remaining item in this group or resource cannot be deleted.
        /// </summary>
        ERROR_CANT_DELETE_LAST_ITEM = 4335, // 0x000010EF
        /// <summary>
        /// The message provided exceeds the maximum size allowed for this parameter.
        /// </summary>
        ERROR_MESSAGE_EXCEEDS_MAX_SIZE = 4336, // 0x000010F0
        /// <summary>The volume contains system or paging files.</summary>
        ERROR_VOLUME_CONTAINS_SYS_FILES = 4337, // 0x000010F1
        /// <summary>
        /// The media type cannot be removed from this library since at least one drive in the library reports it can support this media type.
        /// </summary>
        ERROR_INDIGENOUS_TYPE = 4338, // 0x000010F2
        /// <summary>
        /// This offline media cannot be mounted on this system since no enabled drives are present which can be used.
        /// </summary>
        ERROR_NO_SUPPORTING_DRIVES = 4339, // 0x000010F3
        /// <summary>A cleaner cartridge is present in the tape library.</summary>
        ERROR_CLEANER_CARTRIDGE_INSTALLED = 4340, // 0x000010F4
        /// <summary>
        /// Cannot use the inject/eject port because it is not empty.
        /// </summary>
        ERROR_IEPORT_FULL = 4341, // 0x000010F5
        /// <summary>
        /// This file is currently not available for use on this computer.
        /// </summary>
        ERROR_FILE_OFFLINE = 4350, // 0x000010FE
        /// <summary>
        /// The remote storage service is not operational at this time.
        /// </summary>
        ERROR_REMOTE_STORAGE_NOT_ACTIVE = 4351, // 0x000010FF
        /// <summary>The remote storage service encountered a media error.</summary>
        ERROR_REMOTE_STORAGE_MEDIA_ERROR = 4352, // 0x00001100
        /// <summary>The file or directory is not a reparse point.</summary>
        ERROR_NOT_A_REPARSE_POINT = 4390, // 0x00001126
        /// <summary>
        /// The reparse point attribute cannot be set because it conflicts with an existing attribute.
        /// </summary>
        ERROR_REPARSE_ATTRIBUTE_CONFLICT = 4391, // 0x00001127
        /// <summary>
        /// The data present in the reparse point buffer is invalid.
        /// </summary>
        ERROR_INVALID_REPARSE_DATA = 4392, // 0x00001128
        /// <summary>
        /// The tag present in the reparse point buffer is invalid.
        /// </summary>
        ERROR_REPARSE_TAG_INVALID = 4393, // 0x00001129
        /// <summary>
        /// There is a mismatch between the tag specified in the request and the tag present in the reparse point.
        /// </summary>
        ERROR_REPARSE_TAG_MISMATCH = 4394, // 0x0000112A
        /// <summary>Fast Cache data not found.</summary>
        ERROR_APP_DATA_NOT_FOUND = 4400, // 0x00001130
        /// <summary>Fast Cache data expired.</summary>
        ERROR_APP_DATA_EXPIRED = 4401, // 0x00001131
        /// <summary>Fast Cache data corrupt.</summary>
        ERROR_APP_DATA_CORRUPT = 4402, // 0x00001132
        /// <summary>
        /// Fast Cache data has exceeded its max size and cannot be updated.
        /// </summary>
        ERROR_APP_DATA_LIMIT_EXCEEDED = 4403, // 0x00001133
        /// <summary>
        /// Fast Cache has been ReArmed and requires a reboot until it can be updated.
        /// </summary>
        ERROR_APP_DATA_REBOOT_REQUIRED = 4404, // 0x00001134
        /// <summary>
        /// Secure Boot detected that rollback of protected data has been attempted.
        /// </summary>
        ERROR_SECUREBOOT_ROLLBACK_DETECTED = 4420, // 0x00001144
        /// <summary>
        /// The value is protected by Secure Boot policy and cannot be modified or deleted.
        /// </summary>
        ERROR_SECUREBOOT_POLICY_VIOLATION = 4421, // 0x00001145
        /// <summary>The Secure Boot policy is invalid.</summary>
        ERROR_SECUREBOOT_INVALID_POLICY = 4422, // 0x00001146
        /// <summary>
        /// A new Secure Boot policy did not contain the current publisher on its update list.
        /// </summary>
        ERROR_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND = 4423, // 0x00001147
        /// <summary>
        /// The Secure Boot policy is either not signed or is signed by a non-trusted signer.
        /// </summary>
        ERROR_SECUREBOOT_POLICY_NOT_SIGNED = 4424, // 0x00001148
        /// <summary>Secure Boot is not enabled on this machine.</summary>
        ERROR_SECUREBOOT_NOT_ENABLED = 4425, // 0x00001149
        /// <summary>
        /// Secure Boot requires that certain files and drivers are not replaced by other files or drivers.
        /// </summary>
        ERROR_SECUREBOOT_FILE_REPLACED = 4426, // 0x0000114A
        /// <summary>
        /// The copy offload read operation is not supported by a filter.
        /// </summary>
        ERROR_OFFLOAD_READ_FLT_NOT_SUPPORTED = 4440, // 0x00001158
        /// <summary>
        /// The copy offload write operation is not supported by a filter.
        /// </summary>
        ERROR_OFFLOAD_WRITE_FLT_NOT_SUPPORTED = 4441, // 0x00001159
        /// <summary>
        /// The copy offload read operation is not supported for the file.
        /// </summary>
        ERROR_OFFLOAD_READ_FILE_NOT_SUPPORTED = 4442, // 0x0000115A
        /// <summary>
        /// The copy offload write operation is not supported for the file.
        /// </summary>
        ERROR_OFFLOAD_WRITE_FILE_NOT_SUPPORTED = 4443, // 0x0000115B
        /// <summary>
        /// Single Instance Storage is not available on this volume.
        /// </summary>
        ERROR_VOLUME_NOT_SIS_ENABLED = 4500, // 0x00001194
        /// <summary>
        /// The operation cannot be completed because other resources are dependent on this resource.
        /// </summary>
        ERROR_DEPENDENT_RESOURCE_EXISTS = 5001, // 0x00001389
        /// <summary>The cluster resource dependency cannot be found.</summary>
        ERROR_DEPENDENCY_NOT_FOUND = 5002, // 0x0000138A
        /// <summary>
        /// The cluster resource cannot be made dependent on the specified resource because it is already dependent.
        /// </summary>
        ERROR_DEPENDENCY_ALREADY_EXISTS = 5003, // 0x0000138B
        /// <summary>The cluster resource is not online.</summary>
        ERROR_RESOURCE_NOT_ONLINE = 5004, // 0x0000138C
        /// <summary>A cluster node is not available for this operation.</summary>
        ERROR_HOST_NODE_NOT_AVAILABLE = 5005, // 0x0000138D
        /// <summary>The cluster resource is not available.</summary>
        ERROR_RESOURCE_NOT_AVAILABLE = 5006, // 0x0000138E
        /// <summary>The cluster resource could not be found.</summary>
        ERROR_RESOURCE_NOT_FOUND = 5007, // 0x0000138F
        /// <summary>The cluster is being shut down.</summary>
        ERROR_SHUTDOWN_CLUSTER = 5008, // 0x00001390
        /// <summary>
        /// A cluster node cannot be evicted from the cluster unless the node is down or it is the last node.
        /// </summary>
        ERROR_CANT_EVICT_ACTIVE_NODE = 5009, // 0x00001391
        /// <summary>The object already exists.</summary>
        ERROR_OBJECT_ALREADY_EXISTS = 5010, // 0x00001392
        /// <summary>The object is already in the list.</summary>
        ERROR_OBJECT_IN_LIST = 5011, // 0x00001393
        /// <summary>
        /// The cluster group is not available for any new requests.
        /// </summary>
        ERROR_GROUP_NOT_AVAILABLE = 5012, // 0x00001394
        /// <summary>The cluster group could not be found.</summary>
        ERROR_GROUP_NOT_FOUND = 5013, // 0x00001395
        /// <summary>
        /// The operation could not be completed because the cluster group is not online.
        /// </summary>
        ERROR_GROUP_NOT_ONLINE = 5014, // 0x00001396
        /// <summary>
        /// The operation failed because either the specified cluster node is not the owner of the resource, or the node is not a possible owner of the resource.
        /// </summary>
        ERROR_HOST_NODE_NOT_RESOURCE_OWNER = 5015, // 0x00001397
        /// <summary>
        /// The operation failed because either the specified cluster node is not the owner of the group, or the node is not a possible owner of the group.
        /// </summary>
        ERROR_HOST_NODE_NOT_GROUP_OWNER = 5016, // 0x00001398
        /// <summary>
        /// The cluster resource could not be created in the specified resource monitor.
        /// </summary>
        ERROR_RESMON_CREATE_FAILED = 5017, // 0x00001399
        /// <summary>
        /// The cluster resource could not be brought online by the resource monitor.
        /// </summary>
        ERROR_RESMON_ONLINE_FAILED = 5018, // 0x0000139A
        /// <summary>
        /// The operation could not be completed because the cluster resource is online.
        /// </summary>
        ERROR_RESOURCE_ONLINE = 5019, // 0x0000139B
        /// <summary>
        /// The cluster resource could not be deleted or brought offline because it is the quorum resource.
        /// </summary>
        ERROR_QUORUM_RESOURCE = 5020, // 0x0000139C
        /// <summary>
        /// The cluster could not make the specified resource a quorum resource because it is not capable of being a quorum resource.
        /// </summary>
        ERROR_NOT_QUORUM_CAPABLE = 5021, // 0x0000139D
        /// <summary>The cluster software is shutting down.</summary>
        ERROR_CLUSTER_SHUTTING_DOWN = 5022, // 0x0000139E
        /// <summary>
        /// The group or resource is not in the correct state to perform the requested operation.
        /// </summary>
        ERROR_INVALID_STATE = 5023, // 0x0000139F
        /// <summary>
        /// The properties were stored but not all changes will take effect until the next time the resource is brought online.
        /// </summary>
        ERROR_RESOURCE_PROPERTIES_STORED = 5024, // 0x000013A0
        /// <summary>
        /// The cluster could not make the specified resource a quorum resource because it does not belong to a shared storage class.
        /// </summary>
        ERROR_NOT_QUORUM_CLASS = 5025, // 0x000013A1
        /// <summary>
        /// The cluster resource could not be deleted since it is a core resource.
        /// </summary>
        ERROR_CORE_RESOURCE = 5026, // 0x000013A2
        /// <summary>The quorum resource failed to come online.</summary>
        ERROR_QUORUM_RESOURCE_ONLINE_FAILED = 5027, // 0x000013A3
        /// <summary>
        /// The quorum log could not be created or mounted successfully.
        /// </summary>
        ERROR_QUORUMLOG_OPEN_FAILED = 5028, // 0x000013A4
        /// <summary>The cluster log is corrupt.</summary>
        ERROR_CLUSTERLOG_CORRUPT = 5029, // 0x000013A5
        /// <summary>
        /// The record could not be written to the cluster log since it exceeds the maximum size.
        /// </summary>
        ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE = 5030, // 0x000013A6
        /// <summary>The cluster log exceeds its maximum size.</summary>
        ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE = 5031, // 0x000013A7
        /// <summary>No checkpoint record was found in the cluster log.</summary>
        ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND = 5032, // 0x000013A8
        /// <summary>
        /// The minimum required disk space needed for logging is not available.
        /// </summary>
        ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE = 5033, // 0x000013A9
        /// <summary>
        /// The cluster node failed to take control of the quorum resource because the resource is owned by another active node.
        /// </summary>
        ERROR_QUORUM_OWNER_ALIVE = 5034, // 0x000013AA
        /// <summary>
        /// A cluster network is not available for this operation.
        /// </summary>
        ERROR_NETWORK_NOT_AVAILABLE = 5035, // 0x000013AB
        /// <summary>A cluster node is not available for this operation.</summary>
        ERROR_NODE_NOT_AVAILABLE = 5036, // 0x000013AC
        /// <summary>
        /// All cluster nodes must be running to perform this operation.
        /// </summary>
        ERROR_ALL_NODES_NOT_AVAILABLE = 5037, // 0x000013AD
        /// <summary>A cluster resource failed.</summary>
        ERROR_RESOURCE_FAILED = 5038, // 0x000013AE
        /// <summary>The cluster node is not valid.</summary>
        ERROR_CLUSTER_INVALID_NODE = 5039, // 0x000013AF
        /// <summary>The cluster node already exists.</summary>
        ERROR_CLUSTER_NODE_EXISTS = 5040, // 0x000013B0
        /// <summary>A node is in the process of joining the cluster.</summary>
        ERROR_CLUSTER_JOIN_IN_PROGRESS = 5041, // 0x000013B1
        /// <summary>The cluster node was not found.</summary>
        ERROR_CLUSTER_NODE_NOT_FOUND = 5042, // 0x000013B2
        /// <summary>The cluster local node information was not found.</summary>
        ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND = 5043, // 0x000013B3
        /// <summary>The cluster network already exists.</summary>
        ERROR_CLUSTER_NETWORK_EXISTS = 5044, // 0x000013B4
        /// <summary>The cluster network was not found.</summary>
        ERROR_CLUSTER_NETWORK_NOT_FOUND = 5045, // 0x000013B5
        /// <summary>The cluster network interface already exists.</summary>
        ERROR_CLUSTER_NETINTERFACE_EXISTS = 5046, // 0x000013B6
        /// <summary>The cluster network interface was not found.</summary>
        ERROR_CLUSTER_NETINTERFACE_NOT_FOUND = 5047, // 0x000013B7
        /// <summary>The cluster request is not valid for this object.</summary>
        ERROR_CLUSTER_INVALID_REQUEST = 5048, // 0x000013B8
        /// <summary>The cluster network provider is not valid.</summary>
        ERROR_CLUSTER_INVALID_NETWORK_PROVIDER = 5049, // 0x000013B9
        /// <summary>The cluster node is down.</summary>
        ERROR_CLUSTER_NODE_DOWN = 5050, // 0x000013BA
        /// <summary>The cluster node is not reachable.</summary>
        ERROR_CLUSTER_NODE_UNREACHABLE = 5051, // 0x000013BB
        /// <summary>The cluster node is not a member of the cluster.</summary>
        ERROR_CLUSTER_NODE_NOT_MEMBER = 5052, // 0x000013BC
        /// <summary>A cluster join operation is not in progress.</summary>
        ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS = 5053, // 0x000013BD
        /// <summary>The cluster network is not valid.</summary>
        ERROR_CLUSTER_INVALID_NETWORK = 5054, // 0x000013BE
        /// <summary>The cluster node is up.</summary>
        ERROR_CLUSTER_NODE_UP = 5056, // 0x000013C0
        /// <summary>The cluster IP address is already in use.</summary>
        ERROR_CLUSTER_IPADDR_IN_USE = 5057, // 0x000013C1
        /// <summary>The cluster node is not paused.</summary>
        ERROR_CLUSTER_NODE_NOT_PAUSED = 5058, // 0x000013C2
        /// <summary>No cluster security context is available.</summary>
        ERROR_CLUSTER_NO_SECURITY_CONTEXT = 5059, // 0x000013C3
        /// <summary>
        /// The cluster network is not configured for internal cluster communication.
        /// </summary>
        ERROR_CLUSTER_NETWORK_NOT_INTERNAL = 5060, // 0x000013C4
        /// <summary>The cluster node is already up.</summary>
        ERROR_CLUSTER_NODE_ALREADY_UP = 5061, // 0x000013C5
        /// <summary>The cluster node is already down.</summary>
        ERROR_CLUSTER_NODE_ALREADY_DOWN = 5062, // 0x000013C6
        /// <summary>The cluster network is already online.</summary>
        ERROR_CLUSTER_NETWORK_ALREADY_ONLINE = 5063, // 0x000013C7
        /// <summary>The cluster network is already offline.</summary>
        ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE = 5064, // 0x000013C8
        /// <summary>The cluster node is already a member of the cluster.</summary>
        ERROR_CLUSTER_NODE_ALREADY_MEMBER = 5065, // 0x000013C9
        /// <summary>
        /// The cluster network is the only one configured for internal cluster communication between two or more active cluster nodes. The internal communication capability cannot be removed from the network.
        /// </summary>
        ERROR_CLUSTER_LAST_INTERNAL_NETWORK = 5066, // 0x000013CA
        /// <summary>
        /// One or more cluster resources depend on the network to provide service to clients. The client access capability cannot be removed from the network.
        /// </summary>
        ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS = 5067, // 0x000013CB
        /// <summary>
        /// This operation cannot be performed on the cluster resource as it the quorum resource. You may not bring the quorum resource offline or modify its possible owners list.
        /// </summary>
        ERROR_INVALID_OPERATION_ON_QUORUM = 5068, // 0x000013CC
        /// <summary>
        /// The cluster quorum resource is not allowed to have any dependencies.
        /// </summary>
        ERROR_DEPENDENCY_NOT_ALLOWED = 5069, // 0x000013CD
        /// <summary>The cluster node is paused.</summary>
        ERROR_CLUSTER_NODE_PAUSED = 5070, // 0x000013CE
        /// <summary>
        /// The cluster resource cannot be brought online. The owner node cannot run this resource.
        /// </summary>
        ERROR_NODE_CANT_HOST_RESOURCE = 5071, // 0x000013CF
        /// <summary>
        /// The cluster node is not ready to perform the requested operation.
        /// </summary>
        ERROR_CLUSTER_NODE_NOT_READY = 5072, // 0x000013D0
        /// <summary>The cluster node is shutting down.</summary>
        ERROR_CLUSTER_NODE_SHUTTING_DOWN = 5073, // 0x000013D1
        /// <summary>The cluster join operation was aborted.</summary>
        ERROR_CLUSTER_JOIN_ABORTED = 5074, // 0x000013D2
        /// <summary>
        /// The cluster join operation failed due to incompatible software versions between the joining node and its sponsor.
        /// </summary>
        ERROR_CLUSTER_INCOMPATIBLE_VERSIONS = 5075, // 0x000013D3
        /// <summary>
        /// This resource cannot be created because the cluster has reached the limit on the number of resources it can monitor.
        /// </summary>
        ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED = 5076, // 0x000013D4
        /// <summary>
        /// The system configuration changed during the cluster join or form operation. The join or form operation was aborted.
        /// </summary>
        ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED = 5077, // 0x000013D5
        /// <summary>The specified resource type was not found.</summary>
        ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND = 5078, // 0x000013D6
        /// <summary>
        /// The specified node does not support a resource of this type. This may be due to version inconsistencies or due to the absence of the resource DLL on this node.
        /// </summary>
        ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED = 5079, // 0x000013D7
        /// <summary>
        /// The specified resource name is not supported by this resource DLL. This may be due to a bad (or changed) name supplied to the resource DLL.
        /// </summary>
        ERROR_CLUSTER_RESNAME_NOT_FOUND = 5080, // 0x000013D8
        /// <summary>
        /// No authentication package could be registered with the RPC server.
        /// </summary>
        ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED = 5081, // 0x000013D9
        /// <summary>
        /// You cannot bring the group online because the owner of the group is not in the preferred list for the group. To change the owner node for the group, move the group.
        /// </summary>
        ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST = 5082, // 0x000013DA
        /// <summary>
        /// The join operation failed because the cluster database sequence number has changed or is incompatible with the locker node. This may happen during a join operation if the cluster database was changing during the join.
        /// </summary>
        ERROR_CLUSTER_DATABASE_SEQMISMATCH = 5083, // 0x000013DB
        /// <summary>
        /// The resource monitor will not allow the fail operation to be performed while the resource is in its current state. This may happen if the resource is in a pending state.
        /// </summary>
        ERROR_RESMON_INVALID_STATE = 5084, // 0x000013DC
        /// <summary>
        /// A non locker code got a request to reserve the lock for making global updates.
        /// </summary>
        ERROR_CLUSTER_GUM_NOT_LOCKER = 5085, // 0x000013DD
        /// <summary>
        /// The quorum disk could not be located by the cluster service.
        /// </summary>
        ERROR_QUORUM_DISK_NOT_FOUND = 5086, // 0x000013DE
        /// <summary>The backed up cluster database is possibly corrupt.</summary>
        ERROR_DATABASE_BACKUP_CORRUPT = 5087, // 0x000013DF
        /// <summary>A DFS root already exists in this cluster node.</summary>
        ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT = 5088, // 0x000013E0
        /// <summary>
        /// An attempt to modify a resource property failed because it conflicts with another existing property.
        /// </summary>
        ERROR_RESOURCE_PROPERTY_UNCHANGEABLE = 5089, // 0x000013E1
        /// <summary>
        /// An operation was attempted that is incompatible with the current membership state of the node.
        /// </summary>
        ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE = 5890, // 0x00001702
        /// <summary>The quorum resource does not contain the quorum log.</summary>
        ERROR_CLUSTER_QUORUMLOG_NOT_FOUND = 5891, // 0x00001703
        /// <summary>
        /// The membership engine requested shutdown of the cluster service on this node.
        /// </summary>
        ERROR_CLUSTER_MEMBERSHIP_HALT = 5892, // 0x00001704
        /// <summary>
        /// The join operation failed because the cluster instance ID of the joining node does not match the cluster instance ID of the sponsor node.
        /// </summary>
        ERROR_CLUSTER_INSTANCE_ID_MISMATCH = 5893, // 0x00001705
        /// <summary>
        /// A matching cluster network for the specified IP address could not be found.
        /// </summary>
        ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP = 5894, // 0x00001706
        /// <summary>
        /// The actual data type of the property did not match the expected data type of the property.
        /// </summary>
        ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH = 5895, // 0x00001707
        /// <summary>
        /// The cluster node was evicted from the cluster successfully, but the node was not cleaned up. To determine what cleanup steps failed and how to recover, see the Failover Clustering application event log using Event Viewer.
        /// </summary>
        ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP = 5896, // 0x00001708
        /// <summary>
        /// Two or more parameter values specified for a resource's properties are in conflict.
        /// </summary>
        ERROR_CLUSTER_PARAMETER_MISMATCH = 5897, // 0x00001709
        /// <summary>This computer cannot be made a member of a cluster.</summary>
        ERROR_NODE_CANNOT_BE_CLUSTERED = 5898, // 0x0000170A
        /// <summary>
        /// This computer cannot be made a member of a cluster because it does not have the correct version of Windows installed.
        /// </summary>
        ERROR_CLUSTER_WRONG_OS_VERSION = 5899, // 0x0000170B
        /// <summary>
        /// A cluster cannot be created with the specified cluster name because that cluster name is already in use. Specify a different name for the cluster.
        /// </summary>
        ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME = 5900, // 0x0000170C
        /// <summary>
        /// The cluster configuration action has already been committed.
        /// </summary>
        ERROR_CLUSCFG_ALREADY_COMMITTED = 5901, // 0x0000170D
        /// <summary>
        /// The cluster configuration action could not be rolled back.
        /// </summary>
        ERROR_CLUSCFG_ROLLBACK_FAILED = 5902, // 0x0000170E
        /// <summary>
        /// The drive letter assigned to a system disk on one node conflicted with the drive letter assigned to a disk on another node.
        /// </summary>
        ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT = 5903, // 0x0000170F
        /// <summary>
        /// One or more nodes in the cluster are running a version of Windows that does not support this operation.
        /// </summary>
        ERROR_CLUSTER_OLD_VERSION = 5904, // 0x00001710
        /// <summary>
        /// The name of the corresponding computer account doesn't match the Network Name for this resource.
        /// </summary>
        ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME = 5905, // 0x00001711
        /// <summary>No network adapters are available.</summary>
        ERROR_CLUSTER_NO_NET_ADAPTERS = 5906, // 0x00001712
        /// <summary>The cluster node has been poisoned.</summary>
        ERROR_CLUSTER_POISONED = 5907, // 0x00001713
        /// <summary>
        /// The group is unable to accept the request since it is moving to another node.
        /// </summary>
        ERROR_CLUSTER_GROUP_MOVING = 5908, // 0x00001714
        /// <summary>
        /// The resource type cannot accept the request since is too busy performing another operation.
        /// </summary>
        ERROR_CLUSTER_RESOURCE_TYPE_BUSY = 5909, // 0x00001715
        /// <summary>The call to the cluster resource DLL timed out.</summary>
        ERROR_RESOURCE_CALL_TIMED_OUT = 5910, // 0x00001716
        /// <summary>
        /// The address is not valid for an IPv6 Address resource. A global IPv6 address is required, and it must match a cluster network. Compatibility addresses are not permitted.
        /// </summary>
        ERROR_INVALID_CLUSTER_IPV6_ADDRESS = 5911, // 0x00001717
        /// <summary>
        /// An internal cluster error occurred. A call to an invalid function was attempted.
        /// </summary>
        ERROR_CLUSTER_INTERNAL_INVALID_FUNCTION = 5912, // 0x00001718
        /// <summary>A parameter value is out of acceptable range.</summary>
        ERROR_CLUSTER_PARAMETER_OUT_OF_BOUNDS = 5913, // 0x00001719
        /// <summary>
        /// A network error occurred while sending data to another node in the cluster. The number of bytes transmitted was less than required.
        /// </summary>
        ERROR_CLUSTER_PARTIAL_SEND = 5914, // 0x0000171A
        /// <summary>An invalid cluster registry operation was attempted.</summary>
        ERROR_CLUSTER_REGISTRY_INVALID_FUNCTION = 5915, // 0x0000171B
        /// <summary>
        /// An input string of characters is not properly terminated.
        /// </summary>
        ERROR_CLUSTER_INVALID_STRING_TERMINATION = 5916, // 0x0000171C
        /// <summary>
        /// An input string of characters is not in a valid format for the data it represents.
        /// </summary>
        ERROR_CLUSTER_INVALID_STRING_FORMAT = 5917, // 0x0000171D
        /// <summary>
        /// An internal cluster error occurred. A cluster database transaction was attempted while a transaction was already in progress.
        /// </summary>
        ERROR_CLUSTER_DATABASE_TRANSACTION_IN_PROGRESS = 5918, // 0x0000171E
        /// <summary>
        /// An internal cluster error occurred. There was an attempt to commit a cluster database transaction while no transaction was in progress.
        /// </summary>
        ERROR_CLUSTER_DATABASE_TRANSACTION_NOT_IN_PROGRESS = 5919, // 0x0000171F
        /// <summary>
        /// An internal cluster error occurred. Data was not properly initialized.
        /// </summary>
        ERROR_CLUSTER_NULL_DATA = 5920, // 0x00001720
        /// <summary>
        /// An error occurred while reading from a stream of data. An unexpected number of bytes was returned.
        /// </summary>
        ERROR_CLUSTER_PARTIAL_READ = 5921, // 0x00001721
        /// <summary>
        /// An error occurred while writing to a stream of data. The required number of bytes could not be written.
        /// </summary>
        ERROR_CLUSTER_PARTIAL_WRITE = 5922, // 0x00001722
        /// <summary>
        /// An error occurred while deserializing a stream of cluster data.
        /// </summary>
        ERROR_CLUSTER_CANT_DESERIALIZE_DATA = 5923, // 0x00001723
        /// <summary>
        /// One or more property values for this resource are in conflict with one or more property values associated with its dependent resource(s).
        /// </summary>
        ERROR_DEPENDENT_RESOURCE_PROPERTY_CONFLICT = 5924, // 0x00001724
        /// <summary>
        /// A quorum of cluster nodes was not present to form a cluster.
        /// </summary>
        ERROR_CLUSTER_NO_QUORUM = 5925, // 0x00001725
        /// <summary>
        /// The cluster network is not valid for an IPv6 Address resource, or it does not match the configured address.
        /// </summary>
        ERROR_CLUSTER_INVALID_IPV6_NETWORK = 5926, // 0x00001726
        /// <summary>
        /// The cluster network is not valid for an IPv6 Tunnel resource. Check the configuration of the IP Address resource on which the IPv6 Tunnel resource depends.
        /// </summary>
        ERROR_CLUSTER_INVALID_IPV6_TUNNEL_NETWORK = 5927, // 0x00001727
        /// <summary>
        /// Quorum resource cannot reside in the Available Storage group.
        /// </summary>
        ERROR_QUORUM_NOT_ALLOWED_IN_THIS_GROUP = 5928, // 0x00001728
        /// <summary>
        /// The dependencies for this resource are nested too deeply.
        /// </summary>
        ERROR_DEPENDENCY_TREE_TOO_COMPLEX = 5929, // 0x00001729
        /// <summary>
        /// The call into the resource DLL raised an unhandled exception.
        /// </summary>
        ERROR_EXCEPTION_IN_RESOURCE_CALL = 5930, // 0x0000172A
        /// <summary>The RHS process failed to initialize.</summary>
        ERROR_CLUSTER_RHS_FAILED_INITIALIZATION = 5931, // 0x0000172B
        /// <summary>
        /// The Failover Clustering feature is not installed on this node.
        /// </summary>
        ERROR_CLUSTER_NOT_INSTALLED = 5932, // 0x0000172C
        /// <summary>
        /// The resources must be online on the same node for this operation.
        /// </summary>
        ERROR_CLUSTER_RESOURCES_MUST_BE_ONLINE_ON_THE_SAME_NODE = 5933, // 0x0000172D
        /// <summary>
        /// A new node can not be added since this cluster is already at its maximum number of nodes.
        /// </summary>
        ERROR_CLUSTER_MAX_NODES_IN_CLUSTER = 5934, // 0x0000172E
        /// <summary>
        /// This cluster can not be created since the specified number of nodes exceeds the maximum allowed limit.
        /// </summary>
        ERROR_CLUSTER_TOO_MANY_NODES = 5935, // 0x0000172F
        /// <summary>
        /// An attempt to use the specified cluster name failed because an enabled computer object with the given name already exists in the domain.
        /// </summary>
        ERROR_CLUSTER_OBJECT_ALREADY_USED = 5936, // 0x00001730
        /// <summary>
        /// This cluster cannot be destroyed. It has non-core application groups which must be deleted before the cluster can be destroyed.
        /// </summary>
        ERROR_NONCORE_GROUPS_FOUND = 5937, // 0x00001731
        /// <summary>
        /// File share associated with file share witness resource cannot be hosted by this cluster or any of its nodes.
        /// </summary>
        ERROR_FILE_SHARE_RESOURCE_CONFLICT = 5938, // 0x00001732
        /// <summary>
        /// Eviction of this node is invalid at this time. Due to quorum requirements node eviction will result in cluster shutdown. If it is the last node in the cluster, destroy cluster command should be used.
        /// </summary>
        ERROR_CLUSTER_EVICT_INVALID_REQUEST = 5939, // 0x00001733
        /// <summary>
        /// Only one instance of this resource type is allowed in the cluster.
        /// </summary>
        ERROR_CLUSTER_SINGLETON_RESOURCE = 5940, // 0x00001734
        /// <summary>
        /// Only one instance of this resource type is allowed per resource group.
        /// </summary>
        ERROR_CLUSTER_GROUP_SINGLETON_RESOURCE = 5941, // 0x00001735
        /// <summary>
        /// The resource failed to come online due to the failure of one or more provider resources.
        /// </summary>
        ERROR_CLUSTER_RESOURCE_PROVIDER_FAILED = 5942, // 0x00001736
        /// <summary>
        /// The resource has indicated that it cannot come online on any node.
        /// </summary>
        ERROR_CLUSTER_RESOURCE_CONFIGURATION_ERROR = 5943, // 0x00001737
        /// <summary>
        /// The current operation cannot be performed on this group at this time.
        /// </summary>
        ERROR_CLUSTER_GROUP_BUSY = 5944, // 0x00001738
        /// <summary>
        /// The directory or file is not located on a cluster shared volume.
        /// </summary>
        ERROR_CLUSTER_NOT_SHARED_VOLUME = 5945, // 0x00001739
        /// <summary>
        /// The Security Descriptor does not meet the requirements for a cluster.
        /// </summary>
        ERROR_CLUSTER_INVALID_SECURITY_DESCRIPTOR = 5946, // 0x0000173A
        /// <summary>
        /// There is one or more shared volumes resources configured in the cluster. Those resources must be moved to available storage in order for operation to succeed.
        /// </summary>
        ERROR_CLUSTER_SHARED_VOLUMES_IN_USE = 5947, // 0x0000173B
        /// <summary>
        /// This group or resource cannot be directly manipulated. Use shared volume APIs to perform desired operation.
        /// </summary>
        ERROR_CLUSTER_USE_SHARED_VOLUMES_API = 5948, // 0x0000173C
        /// <summary>
        /// Back up is in progress. Please wait for backup completion before trying this operation again.
        /// </summary>
        ERROR_CLUSTER_BACKUP_IN_PROGRESS = 5949, // 0x0000173D
        /// <summary>The path does not belong to a cluster shared volume.</summary>
        ERROR_NON_CSV_PATH = 5950, // 0x0000173E
        /// <summary>
        /// The cluster shared volume is not locally mounted on this node.
        /// </summary>
        ERROR_CSV_VOLUME_NOT_LOCAL = 5951, // 0x0000173F
        /// <summary>The cluster watchdog is terminating.</summary>
        ERROR_CLUSTER_WATCHDOG_TERMINATING = 5952, // 0x00001740
        /// <summary>
        /// A resource vetoed a move between two nodes because they are incompatible.
        /// </summary>
        ERROR_CLUSTER_RESOURCE_VETOED_MOVE_INCOMPATIBLE_NODES = 5953, // 0x00001741
        /// <summary>
        /// The request is invalid either because node weight cannot be changed while the cluster is in disk-only quorum mode, or because changing the node weight would violate the minimum cluster quorum requirements.
        /// </summary>
        ERROR_CLUSTER_INVALID_NODE_WEIGHT = 5954, // 0x00001742
        /// <summary>The resource vetoed the call.</summary>
        ERROR_CLUSTER_RESOURCE_VETOED_CALL = 5955, // 0x00001743
        /// <summary>
        /// Resource could not start or run because it could not reserve sufficient system resources.
        /// </summary>
        ERROR_RESMON_SYSTEM_RESOURCES_LACKING = 5956, // 0x00001744
        /// <summary>
        /// A resource vetoed a move between two nodes because the destination currently does not have enough resources to complete the operation.
        /// </summary>
        ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_DESTINATION = 5957, // 0x00001745
        /// <summary>
        /// A resource vetoed a move between two nodes because the source currently does not have enough resources to complete the operation.
        /// </summary>
        ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_SOURCE = 5958, // 0x00001746
        /// <summary>
        /// The requested operation can not be completed because the group is queued for an operation.
        /// </summary>
        ERROR_CLUSTER_GROUP_QUEUED = 5959, // 0x00001747
        /// <summary>
        /// The requested operation can not be completed because a resource has locked status.
        /// </summary>
        ERROR_CLUSTER_RESOURCE_LOCKED_STATUS = 5960, // 0x00001748
        /// <summary>
        /// The resource cannot move to another node because a cluster shared volume vetoed the operation.
        /// </summary>
        ERROR_CLUSTER_SHARED_VOLUME_FAILOVER_NOT_ALLOWED = 5961, // 0x00001749
        /// <summary>
        /// A node drain is already in progress. This value was also named ERROR_CLUSTER_NODE_EVACUATION_IN_PROGRESS
        /// </summary>
        ERROR_CLUSTER_NODE_DRAIN_IN_PROGRESS = 5962, // 0x0000174A
        /// <summary>Clustered storage is not connected to the node.</summary>
        ERROR_CLUSTER_DISK_NOT_CONNECTED = 5963, // 0x0000174B
        /// <summary>
        /// The disk is not configured in a way to be used with CSV. CSV disks must have at least one partition that is formatted with NTFS.
        /// </summary>
        ERROR_DISK_NOT_CSV_CAPABLE = 5964, // 0x0000174C
        /// <summary>
        /// The resource must be part of the Available Storage group to complete this action.
        /// </summary>
        ERROR_RESOURCE_NOT_IN_AVAILABLE_STORAGE = 5965, // 0x0000174D
        /// <summary>
        /// CSVFS failed operation as volume is in redirected mode.
        /// </summary>
        ERROR_CLUSTER_SHARED_VOLUME_REDIRECTED = 5966, // 0x0000174E
        /// <summary>
        /// CSVFS failed operation as volume is not in redirected mode.
        /// </summary>
        ERROR_CLUSTER_SHARED_VOLUME_NOT_REDIRECTED = 5967, // 0x0000174F
        /// <summary>Cluster properties cannot be returned at this time.</summary>
        ERROR_CLUSTER_CANNOT_RETURN_PROPERTIES = 5968, // 0x00001750
        /// <summary>
        /// The clustered disk resource contains software snapshot diff area that are not supported for Cluster Shared Volumes.
        /// </summary>
        ERROR_CLUSTER_RESOURCE_CONTAINS_UNSUPPORTED_DIFF_AREA_FOR_SHARED_VOLUMES = 5969, // 0x00001751
        /// <summary>
        /// The operation cannot be completed because the resource is in maintenance mode.
        /// </summary>
        ERROR_CLUSTER_RESOURCE_IS_IN_MAINTENANCE_MODE = 5970, // 0x00001752
        /// <summary>
        /// The operation cannot be completed because of cluster affinity conflicts.
        /// </summary>
        ERROR_CLUSTER_AFFINITY_CONFLICT = 5971, // 0x00001753
        /// <summary>
        /// The operation cannot be completed because the resource is a replica virtual machine.
        /// </summary>
        ERROR_CLUSTER_RESOURCE_IS_REPLICA_VIRTUAL_MACHINE = 5972, // 0x00001754
        /// <summary>The specified file could not be encrypted.</summary>
        ERROR_ENCRYPTION_FAILED = 6000, // 0x00001770
        /// <summary>The specified file could not be decrypted.</summary>
        ERROR_DECRYPTION_FAILED = 6001, // 0x00001771
        /// <summary>
        /// The specified file is encrypted and the user does not have the ability to decrypt it.
        /// </summary>
        ERROR_FILE_ENCRYPTED = 6002, // 0x00001772
        /// <summary>
        /// There is no valid encryption recovery policy configured for this system.
        /// </summary>
        ERROR_NO_RECOVERY_POLICY = 6003, // 0x00001773
        /// <summary>
        /// The required encryption driver is not loaded for this system.
        /// </summary>
        ERROR_NO_EFS = 6004, // 0x00001774
        /// <summary>
        /// The file was encrypted with a different encryption driver than is currently loaded.
        /// </summary>
        ERROR_WRONG_EFS = 6005, // 0x00001775
        /// <summary>There are no EFS keys defined for the user.</summary>
        ERROR_NO_USER_KEYS = 6006, // 0x00001776
        /// <summary>The specified file is not encrypted.</summary>
        ERROR_FILE_NOT_ENCRYPTED = 6007, // 0x00001777
        /// <summary>
        /// The specified file is not in the defined EFS export format.
        /// </summary>
        ERROR_NOT_EXPORT_FORMAT = 6008, // 0x00001778
        /// <summary>The specified file is read only.</summary>
        ERROR_FILE_READ_ONLY = 6009, // 0x00001779
        /// <summary>The directory has been disabled for encryption.</summary>
        ERROR_DIR_EFS_DISALLOWED = 6010, // 0x0000177A
        /// <summary>
        /// The server is not trusted for remote encryption operation.
        /// </summary>
        ERROR_EFS_SERVER_NOT_TRUSTED = 6011, // 0x0000177B
        /// <summary>
        /// Recovery policy configured for this system contains invalid recovery certificate.
        /// </summary>
        ERROR_BAD_RECOVERY_POLICY = 6012, // 0x0000177C
        /// <summary>
        /// The encryption algorithm used on the source file needs a bigger key buffer than the one on the destination file.
        /// </summary>
        ERROR_EFS_ALG_BLOB_TOO_BIG = 6013, // 0x0000177D
        /// <summary>The disk partition does not support file encryption.</summary>
        ERROR_VOLUME_NOT_SUPPORT_EFS = 6014, // 0x0000177E
        /// <summary>This machine is disabled for file encryption.</summary>
        ERROR_EFS_DISABLED = 6015, // 0x0000177F
        /// <summary>
        /// A newer system is required to decrypt this encrypted file.
        /// </summary>
        ERROR_EFS_VERSION_NOT_SUPPORT = 6016, // 0x00001780
        /// <summary>
        /// The remote server sent an invalid response for a file being opened with Client Side Encryption.
        /// </summary>
        ERROR_CS_ENCRYPTION_INVALID_SERVER_RESPONSE = 6017, // 0x00001781
        /// <summary>
        /// Client Side Encryption is not supported by the remote server even though it claims to support it.
        /// </summary>
        ERROR_CS_ENCRYPTION_UNSUPPORTED_SERVER = 6018, // 0x00001782
        /// <summary>
        /// File is encrypted and should be opened in Client Side Encryption mode.
        /// </summary>
        ERROR_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE = 6019, // 0x00001783
        /// <summary>
        /// A new encrypted file is being created and a $EFS needs to be provided.
        /// </summary>
        ERROR_CS_ENCRYPTION_NEW_ENCRYPTED_FILE = 6020, // 0x00001784
        /// <summary>
        /// The SMB client requested a CSE FSCTL on a non-CSE file.
        /// </summary>
        ERROR_CS_ENCRYPTION_FILE_NOT_CSE = 6021, // 0x00001785
        /// <summary>
        /// The requested operation was blocked by policy. For more information, contact your system administrator.
        /// </summary>
        ERROR_ENCRYPTION_POLICY_DENIES_OPERATION = 6022, // 0x00001786
        /// <summary>
        /// The list of servers for this workgroup is not currently available.
        /// </summary>
        ERROR_NO_BROWSER_SERVERS_FOUND = 6118, // 0x000017E6
        /// <summary>
        /// The Task Scheduler service must be configured to run in the System account to function properly. Individual tasks may be configured to run in other accounts.
        /// </summary>
        SCHED_E_SERVICE_NOT_LOCALSYSTEM = 6200, // 0x00001838
        /// <summary>Log service encountered an invalid log sector.</summary>
        ERROR_LOG_SECTOR_INVALID = 6600, // 0x000019C8
        /// <summary>
        /// Log service encountered a log sector with invalid block parity.
        /// </summary>
        ERROR_LOG_SECTOR_PARITY_INVALID = 6601, // 0x000019C9
        /// <summary>Log service encountered a remapped log sector.</summary>
        ERROR_LOG_SECTOR_REMAPPED = 6602, // 0x000019CA
        /// <summary>
        /// Log service encountered a partial or incomplete log block.
        /// </summary>
        ERROR_LOG_BLOCK_INCOMPLETE = 6603, // 0x000019CB
        /// <summary>
        /// Log service encountered an attempt access data outside the active log range.
        /// </summary>
        ERROR_LOG_INVALID_RANGE = 6604, // 0x000019CC
        /// <summary>Log service user marshalling buffers are exhausted.</summary>
        ERROR_LOG_BLOCKS_EXHAUSTED = 6605, // 0x000019CD
        /// <summary>
        /// Log service encountered an attempt read from a marshalling area with an invalid read context.
        /// </summary>
        ERROR_LOG_READ_CONTEXT_INVALID = 6606, // 0x000019CE
        /// <summary>Log service encountered an invalid log restart area.</summary>
        ERROR_LOG_RESTART_INVALID = 6607, // 0x000019CF
        /// <summary>Log service encountered an invalid log block version.</summary>
        ERROR_LOG_BLOCK_VERSION = 6608, // 0x000019D0
        /// <summary>Log service encountered an invalid log block.</summary>
        ERROR_LOG_BLOCK_INVALID = 6609, // 0x000019D1
        /// <summary>
        /// Log service encountered an attempt to read the log with an invalid read mode.
        /// </summary>
        ERROR_LOG_READ_MODE_INVALID = 6610, // 0x000019D2
        /// <summary>
        /// Log service encountered a log stream with no restart area.
        /// </summary>
        ERROR_LOG_NO_RESTART = 6611, // 0x000019D3
        /// <summary>Log service encountered a corrupted metadata file.</summary>
        ERROR_LOG_METADATA_CORRUPT = 6612, // 0x000019D4
        /// <summary>
        /// Log service encountered a metadata file that could not be created by the log file system.
        /// </summary>
        ERROR_LOG_METADATA_INVALID = 6613, // 0x000019D5
        /// <summary>
        /// Log service encountered a metadata file with inconsistent data.
        /// </summary>
        ERROR_LOG_METADATA_INCONSISTENT = 6614, // 0x000019D6
        /// <summary>
        /// Log service encountered an attempt to erroneous allocate or dispose reservation space.
        /// </summary>
        ERROR_LOG_RESERVATION_INVALID = 6615, // 0x000019D7
        /// <summary>
        /// Log service cannot delete log file or file system container.
        /// </summary>
        ERROR_LOG_CANT_DELETE = 6616, // 0x000019D8
        /// <summary>
        /// Log service has reached the maximum allowable containers allocated to a log file.
        /// </summary>
        ERROR_LOG_CONTAINER_LIMIT_EXCEEDED = 6617, // 0x000019D9
        /// <summary>
        /// Log service has attempted to read or write backward past the start of the log.
        /// </summary>
        ERROR_LOG_START_OF_LOG = 6618, // 0x000019DA
        /// <summary>
        /// Log policy could not be installed because a policy of the same type is already present.
        /// </summary>
        ERROR_LOG_POLICY_ALREADY_INSTALLED = 6619, // 0x000019DB
        /// <summary>
        /// Log policy in question was not installed at the time of the request.
        /// </summary>
        ERROR_LOG_POLICY_NOT_INSTALLED = 6620, // 0x000019DC
        /// <summary>The installed set of policies on the log is invalid.</summary>
        ERROR_LOG_POLICY_INVALID = 6621, // 0x000019DD
        /// <summary>
        /// A policy on the log in question prevented the operation from completing.
        /// </summary>
        ERROR_LOG_POLICY_CONFLICT = 6622, // 0x000019DE
        /// <summary>
        /// Log space cannot be reclaimed because the log is pinned by the archive tail.
        /// </summary>
        ERROR_LOG_PINNED_ARCHIVE_TAIL = 6623, // 0x000019DF
        /// <summary>Log record is not a record in the log file.</summary>
        ERROR_LOG_RECORD_NONEXISTENT = 6624, // 0x000019E0
        /// <summary>
        /// Number of reserved log records or the adjustment of the number of reserved log records is invalid.
        /// </summary>
        ERROR_LOG_RECORDS_RESERVED_INVALID = 6625, // 0x000019E1
        /// <summary>
        /// Reserved log space or the adjustment of the log space is invalid.
        /// </summary>
        ERROR_LOG_SPACE_RESERVED_INVALID = 6626, // 0x000019E2
        /// <summary>
        /// An new or existing archive tail or base of the active log is invalid.
        /// </summary>
        ERROR_LOG_TAIL_INVALID = 6627, // 0x000019E3
        /// <summary>Log space is exhausted.</summary>
        ERROR_LOG_FULL = 6628, // 0x000019E4
        /// <summary>The log could not be set to the requested size.</summary>
        ERROR_COULD_NOT_RESIZE_LOG = 6629, // 0x000019E5
        /// <summary>
        /// Log is multiplexed, no direct writes to the physical log is allowed.
        /// </summary>
        ERROR_LOG_MULTIPLEXED = 6630, // 0x000019E6
        /// <summary>
        /// The operation failed because the log is a dedicated log.
        /// </summary>
        ERROR_LOG_DEDICATED = 6631, // 0x000019E7
        /// <summary>The operation requires an archive context.</summary>
        ERROR_LOG_ARCHIVE_NOT_IN_PROGRESS = 6632, // 0x000019E8
        /// <summary>Log archival is in progress.</summary>
        ERROR_LOG_ARCHIVE_IN_PROGRESS = 6633, // 0x000019E9
        /// <summary>
        /// The operation requires a non-ephemeral log, but the log is ephemeral.
        /// </summary>
        ERROR_LOG_EPHEMERAL = 6634, // 0x000019EA
        /// <summary>
        /// The log must have at least two containers before it can be read from or written to.
        /// </summary>
        ERROR_LOG_NOT_ENOUGH_CONTAINERS = 6635, // 0x000019EB
        /// <summary>A log client has already registered on the stream.</summary>
        ERROR_LOG_CLIENT_ALREADY_REGISTERED = 6636, // 0x000019EC
        /// <summary>A log client has not been registered on the stream.</summary>
        ERROR_LOG_CLIENT_NOT_REGISTERED = 6637, // 0x000019ED
        /// <summary>
        /// A request has already been made to handle the log full condition.
        /// </summary>
        ERROR_LOG_FULL_HANDLER_IN_PROGRESS = 6638, // 0x000019EE
        /// <summary>
        /// Log service encountered an error when attempting to read from a log container.
        /// </summary>
        ERROR_LOG_CONTAINER_READ_FAILED = 6639, // 0x000019EF
        /// <summary>
        /// Log service encountered an error when attempting to write to a log container.
        /// </summary>
        ERROR_LOG_CONTAINER_WRITE_FAILED = 6640, // 0x000019F0
        /// <summary>
        /// Log service encountered an error when attempting open a log container.
        /// </summary>
        ERROR_LOG_CONTAINER_OPEN_FAILED = 6641, // 0x000019F1
        /// <summary>
        /// Log service encountered an invalid container state when attempting a requested action.
        /// </summary>
        ERROR_LOG_CONTAINER_STATE_INVALID = 6642, // 0x000019F2
        /// <summary>
        /// Log service is not in the correct state to perform a requested action.
        /// </summary>
        ERROR_LOG_STATE_INVALID = 6643, // 0x000019F3
        /// <summary>
        /// Log space cannot be reclaimed because the log is pinned.
        /// </summary>
        ERROR_LOG_PINNED = 6644, // 0x000019F4
        /// <summary>Log metadata flush failed.</summary>
        ERROR_LOG_METADATA_FLUSH_FAILED = 6645, // 0x000019F5
        /// <summary>
        /// Security on the log and its containers is inconsistent.
        /// </summary>
        ERROR_LOG_INCONSISTENT_SECURITY = 6646, // 0x000019F6
        /// <summary>
        /// Records were appended to the log or reservation changes were made, but the log could not be flushed.
        /// </summary>
        ERROR_LOG_APPENDED_FLUSH_FAILED = 6647, // 0x000019F7
        /// <summary>
        /// The log is pinned due to reservation consuming most of the log space. Free some reserved records to make space available.
        /// </summary>
        ERROR_LOG_PINNED_RESERVATION = 6648, // 0x000019F8
        /// <summary>
        /// The transaction handle associated with this operation is not valid.
        /// </summary>
        ERROR_INVALID_TRANSACTION = 6700, // 0x00001A2C
        /// <summary>
        /// The requested operation was made in the context of a transaction that is no longer active.
        /// </summary>
        ERROR_TRANSACTION_NOT_ACTIVE = 6701, // 0x00001A2D
        /// <summary>
        /// The requested operation is not valid on the Transaction object in its current state.
        /// </summary>
        ERROR_TRANSACTION_REQUEST_NOT_VALID = 6702, // 0x00001A2E
        /// <summary>
        /// The caller has called a response API, but the response is not expected because the TM did not issue the corresponding request to the caller.
        /// </summary>
        ERROR_TRANSACTION_NOT_REQUESTED = 6703, // 0x00001A2F
        /// <summary>
        /// It is too late to perform the requested operation, since the Transaction has already been aborted.
        /// </summary>
        ERROR_TRANSACTION_ALREADY_ABORTED = 6704, // 0x00001A30
        /// <summary>
        /// It is too late to perform the requested operation, since the Transaction has already been committed.
        /// </summary>
        ERROR_TRANSACTION_ALREADY_COMMITTED = 6705, // 0x00001A31
        /// <summary>
        /// The Transaction Manager was unable to be successfully initialized. Transacted operations are not supported.
        /// </summary>
        ERROR_TM_INITIALIZATION_FAILED = 6706, // 0x00001A32
        /// <summary>
        /// The specified ResourceManager made no changes or updates to the resource under this transaction.
        /// </summary>
        ERROR_RESOURCEMANAGER_READ_ONLY = 6707, // 0x00001A33
        /// <summary>
        /// The resource manager has attempted to prepare a transaction that it has not successfully joined.
        /// </summary>
        ERROR_TRANSACTION_NOT_JOINED = 6708, // 0x00001A34
        /// <summary>
        /// The Transaction object already has a superior enlistment, and the caller attempted an operation that would have created a new superior. Only a single superior enlistment is allow.
        /// </summary>
        ERROR_TRANSACTION_SUPERIOR_EXISTS = 6709, // 0x00001A35
        /// <summary>
        /// The RM tried to register a protocol that already exists.
        /// </summary>
        ERROR_CRM_PROTOCOL_ALREADY_EXISTS = 6710, // 0x00001A36
        /// <summary>The attempt to propagate the Transaction failed.</summary>
        ERROR_TRANSACTION_PROPAGATION_FAILED = 6711, // 0x00001A37
        /// <summary>
        /// The requested propagation protocol was not registered as a CRM.
        /// </summary>
        ERROR_CRM_PROTOCOL_NOT_FOUND = 6712, // 0x00001A38
        /// <summary>
        /// The buffer passed in to PushTransaction or PullTransaction is not in a valid format.
        /// </summary>
        ERROR_TRANSACTION_INVALID_MARSHALL_BUFFER = 6713, // 0x00001A39
        /// <summary>
        /// The current transaction context associated with the thread is not a valid handle to a transaction object.
        /// </summary>
        ERROR_CURRENT_TRANSACTION_NOT_VALID = 6714, // 0x00001A3A
        /// <summary>
        /// The specified Transaction object could not be opened, because it was not found.
        /// </summary>
        ERROR_TRANSACTION_NOT_FOUND = 6715, // 0x00001A3B
        /// <summary>
        /// The specified ResourceManager object could not be opened, because it was not found.
        /// </summary>
        ERROR_RESOURCEMANAGER_NOT_FOUND = 6716, // 0x00001A3C
        /// <summary>
        /// The specified Enlistment object could not be opened, because it was not found.
        /// </summary>
        ERROR_ENLISTMENT_NOT_FOUND = 6717, // 0x00001A3D
        /// <summary>
        /// The specified TransactionManager object could not be opened, because it was not found.
        /// </summary>
        ERROR_TRANSACTIONMANAGER_NOT_FOUND = 6718, // 0x00001A3E
        /// <summary>
        /// The object specified could not be created or opened, because its associated TransactionManager is not online. The TransactionManager must be brought fully Online by calling RecoverTransactionManager to recover to the end of its LogFile before objects in its Transaction or ResourceManager namespaces can be opened.  In addition, errors in writing records to its LogFile can cause a TransactionManager to go offline.
        /// </summary>
        ERROR_TRANSACTIONMANAGER_NOT_ONLINE = 6719, // 0x00001A3F
        /// <summary>
        /// The specified TransactionManager was unable to create the objects contained in its logfile in the Ob namespace. Therefore, the TransactionManager was unable to recover.
        /// </summary>
        ERROR_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION = 6720, // 0x00001A40
        /// <summary>
        /// The call to create a superior Enlistment on this Transaction object could not be completed, because the Transaction object specified for the enlistment is a subordinate branch of the Transaction. Only the root of the Transaction can be enlisted on as a superior.
        /// </summary>
        ERROR_TRANSACTION_NOT_ROOT = 6721, // 0x00001A41
        /// <summary>
        /// Because the associated transaction manager or resource manager has been closed, the handle is no longer valid.
        /// </summary>
        ERROR_TRANSACTION_OBJECT_EXPIRED = 6722, // 0x00001A42
        /// <summary>
        /// The specified operation could not be performed on this Superior enlistment, because the enlistment was not created with the corresponding completion response in the NotificationMask.
        /// </summary>
        ERROR_TRANSACTION_RESPONSE_NOT_ENLISTED = 6723, // 0x00001A43
        /// <summary>
        /// The specified operation could not be performed, because the record that would be logged was too long. This can occur because of two conditions: either there are too many Enlistments on this Transaction, or the combined RecoveryInformation being logged on behalf of those Enlistments is too long.
        /// </summary>
        ERROR_TRANSACTION_RECORD_TOO_LONG = 6724, // 0x00001A44
        /// <summary>Implicit transaction are not supported.</summary>
        ERROR_IMPLICIT_TRANSACTION_NOT_SUPPORTED = 6725, // 0x00001A45
        /// <summary>
        /// The kernel transaction manager had to abort or forget the transaction because it blocked forward progress.
        /// </summary>
        ERROR_TRANSACTION_INTEGRITY_VIOLATED = 6726, // 0x00001A46
        /// <summary>
        /// The TransactionManager identity that was supplied did not match the one recorded in the TransactionManager's log file.
        /// </summary>
        ERROR_TRANSACTIONMANAGER_IDENTITY_MISMATCH = 6727, // 0x00001A47
        /// <summary>
        /// This snapshot operation cannot continue because a transactional resource manager cannot be frozen in its current state.  Please try again.
        /// </summary>
        ERROR_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT = 6728, // 0x00001A48
        /// <summary>
        /// The transaction cannot be enlisted on with the specified EnlistmentMask, because the transaction has already completed the PrePrepare phase.  In order to ensure correctness, the ResourceManager must switch to a write-      through mode and cease caching data within this transaction.  Enlisting for only subsequent transaction phases may still succeed.
        /// </summary>
        ERROR_TRANSACTION_MUST_WRITETHROUGH = 6729, // 0x00001A49
        /// <summary>The transaction does not have a superior enlistment.</summary>
        ERROR_TRANSACTION_NO_SUPERIOR = 6730, // 0x00001A4A
        /// <summary>
        /// The attempt to commit the Transaction completed, but it is possible that some portion of the transaction tree did not commit successfully due to heuristics.  Therefore it is possible that some data modified in the transaction may not have committed, resulting in transactional inconsistency.  If possible, check the consistency of the associated data.
        /// </summary>
        ERROR_HEURISTIC_DAMAGE_POSSIBLE = 6731, // 0x00001A4B
        /// <summary>
        /// The function attempted to use a name that is reserved for use by another transaction.
        /// </summary>
        ERROR_TRANSACTIONAL_CONFLICT = 6800, // 0x00001A90
        /// <summary>
        /// Transaction support within the specified resource manager is not started or was shut down due to an error.
        /// </summary>
        ERROR_RM_NOT_ACTIVE = 6801, // 0x00001A91
        /// <summary>
        /// The metadata of the RM has been corrupted. The RM will not function.
        /// </summary>
        ERROR_RM_METADATA_CORRUPT = 6802, // 0x00001A92
        /// <summary>
        /// The specified directory does not contain a resource manager.
        /// </summary>
        ERROR_DIRECTORY_NOT_RM = 6803, // 0x00001A93
        /// <summary>
        /// The remote server or share does not support transacted file operations.
        /// </summary>
        ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE = 6805, // 0x00001A95
        /// <summary>The requested log size is invalid.</summary>
        ERROR_LOG_RESIZE_INVALID_SIZE = 6806, // 0x00001A96
        /// <summary>
        /// The object (file, stream, link) corresponding to the handle has been deleted by a Transaction Savepoint Rollback.
        /// </summary>
        ERROR_OBJECT_NO_LONGER_EXISTS = 6807, // 0x00001A97
        /// <summary>
        /// The specified file miniversion was not found for this transacted file open.
        /// </summary>
        ERROR_STREAM_MINIVERSION_NOT_FOUND = 6808, // 0x00001A98
        /// <summary>
        /// The specified file miniversion was found but has been invalidated. Most likely cause is a transaction savepoint rollback.
        /// </summary>
        ERROR_STREAM_MINIVERSION_NOT_VALID = 6809, // 0x00001A99
        /// <summary>
        /// A miniversion may only be opened in the context of the transaction that created it.
        /// </summary>
        ERROR_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION = 6810, // 0x00001A9A
        /// <summary>
        /// It is not possible to open a miniversion with modify access.
        /// </summary>
        ERROR_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT = 6811, // 0x00001A9B
        /// <summary>
        /// It is not possible to create any more miniversions for this stream.
        /// </summary>
        ERROR_CANT_CREATE_MORE_STREAM_MINIVERSIONS = 6812, // 0x00001A9C
        /// <summary>
        /// The remote server sent mismatching version number or Fid for a file opened with transactions.
        /// </summary>
        ERROR_REMOTE_FILE_VERSION_MISMATCH = 6814, // 0x00001A9E
        /// <summary>
        /// The handle has been invalidated by a transaction. The most likely cause is the presence of memory mapping on a file or an open handle when the transaction ended or rolled back to savepoint.
        /// </summary>
        ERROR_HANDLE_NO_LONGER_VALID = 6815, // 0x00001A9F
        /// <summary>There is no transaction metadata on the file.</summary>
        ERROR_NO_TXF_METADATA = 6816, // 0x00001AA0
        /// <summary>The log data is corrupt.</summary>
        ERROR_LOG_CORRUPTION_DETECTED = 6817, // 0x00001AA1
        /// <summary>
        /// The file can't be recovered because there is a handle still open on it.
        /// </summary>
        ERROR_CANT_RECOVER_WITH_HANDLE_OPEN = 6818, // 0x00001AA2
        /// <summary>
        /// The transaction outcome is unavailable because the resource manager responsible for it has disconnected.
        /// </summary>
        ERROR_RM_DISCONNECTED = 6819, // 0x00001AA3
        /// <summary>
        /// The request was rejected because the enlistment in question is not a superior enlistment.
        /// </summary>
        ERROR_ENLISTMENT_NOT_SUPERIOR = 6820, // 0x00001AA4
        /// <summary>
        /// The transactional resource manager is already consistent. Recovery is not needed.
        /// </summary>
        ERROR_RECOVERY_NOT_NEEDED = 6821, // 0x00001AA5
        /// <summary>
        /// The transactional resource manager has already been started.
        /// </summary>
        ERROR_RM_ALREADY_STARTED = 6822, // 0x00001AA6
        /// <summary>
        /// The file cannot be opened transactionally, because its identity depends on the outcome of an unresolved transaction.
        /// </summary>
        ERROR_FILE_IDENTITY_NOT_PERSISTENT = 6823, // 0x00001AA7
        /// <summary>
        /// The operation cannot be performed because another transaction is depending on the fact that this property will not change.
        /// </summary>
        ERROR_CANT_BREAK_TRANSACTIONAL_DEPENDENCY = 6824, // 0x00001AA8
        /// <summary>
        /// The operation would involve a single file with two transactional resource managers and is therefore not allowed.
        /// </summary>
        ERROR_CANT_CROSS_RM_BOUNDARY = 6825, // 0x00001AA9
        /// <summary>
        /// The $Txf directory must be empty for this operation to succeed.
        /// </summary>
        ERROR_TXF_DIR_NOT_EMPTY = 6826, // 0x00001AAA
        /// <summary>
        /// The operation would leave a transactional resource manager in an inconsistent state and is therefore not allowed.
        /// </summary>
        ERROR_INDOUBT_TRANSACTIONS_EXIST = 6827, // 0x00001AAB
        /// <summary>
        /// The operation could not be completed because the transaction manager does not have a log.
        /// </summary>
        ERROR_TM_VOLATILE = 6828, // 0x00001AAC
        /// <summary>
        /// A rollback could not be scheduled because a previously scheduled rollback has already executed or been queued for execution.
        /// </summary>
        ERROR_ROLLBACK_TIMER_EXPIRED = 6829, // 0x00001AAD
        /// <summary>
        /// The transactional metadata attribute on the file or directory is corrupt and unreadable.
        /// </summary>
        ERROR_TXF_ATTRIBUTE_CORRUPT = 6830, // 0x00001AAE
        /// <summary>
        /// The encryption operation could not be completed because a transaction is active.
        /// </summary>
        ERROR_EFS_NOT_ALLOWED_IN_TRANSACTION = 6831, // 0x00001AAF
        /// <summary>
        /// This object is not allowed to be opened in a transaction.
        /// </summary>
        ERROR_TRANSACTIONAL_OPEN_NOT_ALLOWED = 6832, // 0x00001AB0
        /// <summary>
        /// An attempt to create space in the transactional resource manager's log failed. The failure status has been recorded in the event log.
        /// </summary>
        ERROR_LOG_GROWTH_FAILED = 6833, // 0x00001AB1
        /// <summary>
        /// Memory mapping (creating a mapped section) a remote file under a transaction is not supported.
        /// </summary>
        ERROR_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE = 6834, // 0x00001AB2
        /// <summary>
        /// Transaction metadata is already present on this file and cannot be superseded.
        /// </summary>
        ERROR_TXF_METADATA_ALREADY_PRESENT = 6835, // 0x00001AB3
        /// <summary>
        /// A transaction scope could not be entered because the scope handler has not been initialized.
        /// </summary>
        ERROR_TRANSACTION_SCOPE_CALLBACKS_NOT_SET = 6836, // 0x00001AB4
        /// <summary>
        /// Promotion was required in order to allow the resource manager to enlist, but the transaction was set to disallow it.
        /// </summary>
        ERROR_TRANSACTION_REQUIRED_PROMOTION = 6837, // 0x00001AB5
        /// <summary>
        /// This file is open for modification in an unresolved transaction and may be opened for execute only by a transacted reader.
        /// </summary>
        ERROR_CANNOT_EXECUTE_FILE_IN_TRANSACTION = 6838, // 0x00001AB6
        /// <summary>
        /// The request to thaw frozen transactions was ignored because transactions had not previously been frozen.
        /// </summary>
        ERROR_TRANSACTIONS_NOT_FROZEN = 6839, // 0x00001AB7
        /// <summary>
        /// Transactions cannot be frozen because a freeze is already in progress.
        /// </summary>
        ERROR_TRANSACTION_FREEZE_IN_PROGRESS = 6840, // 0x00001AB8
        /// <summary>
        /// The target volume is not a snapshot volume. This operation is only valid on a volume mounted as a snapshot.
        /// </summary>
        ERROR_NOT_SNAPSHOT_VOLUME = 6841, // 0x00001AB9
        /// <summary>
        /// The savepoint operation failed because files are open on the transaction. This is not permitted.
        /// </summary>
        ERROR_NO_SAVEPOINT_WITH_OPEN_FILES = 6842, // 0x00001ABA
        /// <summary>
        /// Windows has discovered corruption in a file, and that file has since been repaired. Data loss may have occurred.
        /// </summary>
        ERROR_DATA_LOST_REPAIR = 6843, // 0x00001ABB
        /// <summary>
        /// The sparse operation could not be completed because a transaction is active on the file.
        /// </summary>
        ERROR_SPARSE_NOT_ALLOWED_IN_TRANSACTION = 6844, // 0x00001ABC
        /// <summary>
        /// The call to create a TransactionManager object failed because the Tm Identity stored in the logfile does not match the Tm Identity that was passed in as an argument.
        /// </summary>
        ERROR_TM_IDENTITY_MISMATCH = 6845, // 0x00001ABD
        /// <summary>
        /// I/O was attempted on a section object that has been floated as a result of a transaction ending. There is no valid data.
        /// </summary>
        ERROR_FLOATED_SECTION = 6846, // 0x00001ABE
        /// <summary>
        /// The transactional resource manager cannot currently accept transacted work due to a transient condition such as low resources.
        /// </summary>
        ERROR_CANNOT_ACCEPT_TRANSACTED_WORK = 6847, // 0x00001ABF
        /// <summary>
        /// The transactional resource manager had too many tranactions outstanding that could not be aborted. The transactional resource manger has been shut down.
        /// </summary>
        ERROR_CANNOT_ABORT_TRANSACTIONS = 6848, // 0x00001AC0
        /// <summary>
        /// The operation could not be completed due to bad clusters on disk.
        /// </summary>
        ERROR_BAD_CLUSTERS = 6849, // 0x00001AC1
        /// <summary>
        /// The compression operation could not be completed because a transaction is active on the file.
        /// </summary>
        ERROR_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION = 6850, // 0x00001AC2
        /// <summary>
        /// The operation could not be completed because the volume is dirty. Please run chkdsk and try again.
        /// </summary>
        ERROR_VOLUME_DIRTY = 6851, // 0x00001AC3
        /// <summary>
        /// The link tracking operation could not be completed because a transaction is active.
        /// </summary>
        ERROR_NO_LINK_TRACKING_IN_TRANSACTION = 6852, // 0x00001AC4
        /// <summary>This operation cannot be performed in a transaction.</summary>
        ERROR_OPERATION_NOT_SUPPORTED_IN_TRANSACTION = 6853, // 0x00001AC5
        /// <summary>
        /// The handle is no longer properly associated with its transaction.  It may have been opened in a transactional resource manager that was subsequently forced to restart.  Please close the handle and open a new one.
        /// </summary>
        ERROR_EXPIRED_HANDLE = 6854, // 0x00001AC6
        /// <summary>
        /// The specified operation could not be performed because the resource manager is not enlisted in the transaction.
        /// </summary>
        ERROR_TRANSACTION_NOT_ENLISTED = 6855, // 0x00001AC7
        /// <summary>The specified session name is invalid.</summary>
        ERROR_CTX_WINSTATION_NAME_INVALID = 7001, // 0x00001B59
        /// <summary>The specified protocol driver is invalid.</summary>
        ERROR_CTX_INVALID_PD = 7002, // 0x00001B5A
        /// <summary>
        /// The specified protocol driver was not found in the system path.
        /// </summary>
        ERROR_CTX_PD_NOT_FOUND = 7003, // 0x00001B5B
        /// <summary>
        /// The specified terminal connection driver was not found in the system path.
        /// </summary>
        ERROR_CTX_WD_NOT_FOUND = 7004, // 0x00001B5C
        /// <summary>
        /// A registry key for event logging could not be created for this session.
        /// </summary>
        ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY = 7005, // 0x00001B5D
        /// <summary>
        /// A service with the same name already exists on the system.
        /// </summary>
        ERROR_CTX_SERVICE_NAME_COLLISION = 7006, // 0x00001B5E
        /// <summary>A close operation is pending on the session.</summary>
        ERROR_CTX_CLOSE_PENDING = 7007, // 0x00001B5F
        /// <summary>There are no free output buffers available.</summary>
        ERROR_CTX_NO_OUTBUF = 7008, // 0x00001B60
        /// <summary>The MODEM.INF file was not found.</summary>
        ERROR_CTX_MODEM_INF_NOT_FOUND = 7009, // 0x00001B61
        /// <summary>The modem name was not found in MODEM.INF.</summary>
        ERROR_CTX_INVALID_MODEMNAME = 7010, // 0x00001B62
        /// <summary>
        /// The modem did not accept the command sent to it. Verify that the configured modem name matches the attached modem.
        /// </summary>
        ERROR_CTX_MODEM_RESPONSE_ERROR = 7011, // 0x00001B63
        /// <summary>
        /// The modem did not respond to the command sent to it. Verify that the modem is properly cabled and powered on.
        /// </summary>
        ERROR_CTX_MODEM_RESPONSE_TIMEOUT = 7012, // 0x00001B64
        /// <summary>
        /// Carrier detect has failed or carrier has been dropped due to disconnect.
        /// </summary>
        ERROR_CTX_MODEM_RESPONSE_NO_CARRIER = 7013, // 0x00001B65
        /// <summary>
        /// Dial tone not detected within the required time. Verify that the phone cable is properly attached and functional.
        /// </summary>
        ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE = 7014, // 0x00001B66
        /// <summary>Busy signal detected at remote site on callback.</summary>
        ERROR_CTX_MODEM_RESPONSE_BUSY = 7015, // 0x00001B67
        /// <summary>Voice detected at remote site on callback.</summary>
        ERROR_CTX_MODEM_RESPONSE_VOICE = 7016, // 0x00001B68
        /// <summary>Transport driver error.</summary>
        ERROR_CTX_TD_ERROR = 7017, // 0x00001B69
        /// <summary>The specified session cannot be found.</summary>
        ERROR_CTX_WINSTATION_NOT_FOUND = 7022, // 0x00001B6E
        /// <summary>The specified session name is already in use.</summary>
        ERROR_CTX_WINSTATION_ALREADY_EXISTS = 7023, // 0x00001B6F
        /// <summary>
        /// The task you are trying to do can't be completed because Remote Desktop Services is currently busy. Please try again in a few minutes. Other users should still be able to log on.
        /// </summary>
        ERROR_CTX_WINSTATION_BUSY = 7024, // 0x00001B70
        /// <summary>
        /// An attempt has been made to connect to a session whose video mode is not supported by the current client.
        /// </summary>
        ERROR_CTX_BAD_VIDEO_MODE = 7025, // 0x00001B71
        /// <summary>
        /// The application attempted to enable DOS graphics mode. DOS graphics mode is not supported.
        /// </summary>
        ERROR_CTX_GRAPHICS_INVALID = 7035, // 0x00001B7B
        /// <summary>
        /// Your interactive logon privilege has been disabled. Please contact your administrator.
        /// </summary>
        ERROR_CTX_LOGON_DISABLED = 7037, // 0x00001B7D
        /// <summary>
        /// The requested operation can be performed only on the system console. This is most often the result of a driver or system DLL requiring direct console access.
        /// </summary>
        ERROR_CTX_NOT_CONSOLE = 7038, // 0x00001B7E
        /// <summary>
        /// The client failed to respond to the server connect message.
        /// </summary>
        ERROR_CTX_CLIENT_QUERY_TIMEOUT = 7040, // 0x00001B80
        /// <summary>Disconnecting the console session is not supported.</summary>
        ERROR_CTX_CONSOLE_DISCONNECT = 7041, // 0x00001B81
        /// <summary>
        /// Reconnecting a disconnected session to the console is not supported.
        /// </summary>
        ERROR_CTX_CONSOLE_CONNECT = 7042, // 0x00001B82
        /// <summary>
        /// The request to control another session remotely was denied.
        /// </summary>
        ERROR_CTX_SHADOW_DENIED = 7044, // 0x00001B84
        /// <summary>The requested session access is denied.</summary>
        ERROR_CTX_WINSTATION_ACCESS_DENIED = 7045, // 0x00001B85
        /// <summary>The specified terminal connection driver is invalid.</summary>
        ERROR_CTX_INVALID_WD = 7049, // 0x00001B89
        /// <summary>
        /// The requested session cannot be controlled remotely. This may be because the session is disconnected or does not currently have a user logged on.
        /// </summary>
        ERROR_CTX_SHADOW_INVALID = 7050, // 0x00001B8A
        /// <summary>
        /// The requested session is not configured to allow remote control.
        /// </summary>
        ERROR_CTX_SHADOW_DISABLED = 7051, // 0x00001B8B
        /// <summary>
        /// Your request to connect to this Terminal Server has been rejected. Your Terminal Server client license number is currently being used by another user. Please call your system administrator to obtain a unique license number.
        /// </summary>
        ERROR_CTX_CLIENT_LICENSE_IN_USE = 7052, // 0x00001B8C
        /// <summary>
        /// Your request to connect to this Terminal Server has been rejected. Your Terminal Server client license number has not been entered for this copy of the Terminal Server client. Please contact your system administrator.
        /// </summary>
        ERROR_CTX_CLIENT_LICENSE_NOT_SET = 7053, // 0x00001B8D
        /// <summary>
        /// The number of connections to this computer is limited and all connections are in use right now. Try connecting later or contact your system administrator.
        /// </summary>
        ERROR_CTX_LICENSE_NOT_AVAILABLE = 7054, // 0x00001B8E
        /// <summary>
        /// The client you are using is not licensed to use this system. Your logon request is denied.
        /// </summary>
        ERROR_CTX_LICENSE_CLIENT_INVALID = 7055, // 0x00001B8F
        /// <summary>
        /// The system license has expired. Your logon request is denied.
        /// </summary>
        ERROR_CTX_LICENSE_EXPIRED = 7056, // 0x00001B90
        /// <summary>
        /// Remote control could not be terminated because the specified session is not currently being remotely controlled.
        /// </summary>
        ERROR_CTX_SHADOW_NOT_RUNNING = 7057, // 0x00001B91
        /// <summary>
        /// The remote control of the console was terminated because the display mode was changed. Changing the display mode in a remote control session is not supported.
        /// </summary>
        ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE = 7058, // 0x00001B92
        /// <summary>
        /// Activation has already been reset the maximum number of times for this installation. Your activation timer will not be cleared.
        /// </summary>
        ERROR_ACTIVATION_COUNT_EXCEEDED = 7059, // 0x00001B93
        /// <summary>Remote logins are currently disabled.</summary>
        ERROR_CTX_WINSTATIONS_DISABLED = 7060, // 0x00001B94
        /// <summary>
        /// You do not have the proper encryption level to access this Session.
        /// </summary>
        ERROR_CTX_ENCRYPTION_LEVEL_REQUIRED = 7061, // 0x00001B95
        /// <summary>
        /// The user %s\\\\%s is currently logged on to this computer. Only the current user or an administrator can log on to this computer.
        /// </summary>
        ERROR_CTX_SESSION_IN_USE = 7062, // 0x00001B96
        /// <summary>
        /// The user %s\\\\%s is already logged on to the console of this computer. You do not have permission to log in at this time. To resolve this issue, contact %s\\\\%s and have them log off.
        /// </summary>
        ERROR_CTX_NO_FORCE_LOGOFF = 7063, // 0x00001B97
        /// <summary>
        /// Unable to log you on because of an account restriction.
        /// </summary>
        ERROR_CTX_ACCOUNT_RESTRICTION = 7064, // 0x00001B98
        /// <summary>
        /// The RDP protocol component %2 detected an error in the protocol stream and has disconnected the client.
        /// </summary>
        ERROR_RDP_PROTOCOL_ERROR = 7065, // 0x00001B99
        /// <summary>
        /// The Client Drive Mapping Service Has Connected on Terminal Connection.
        /// </summary>
        ERROR_CTX_CDM_CONNECT = 7066, // 0x00001B9A
        /// <summary>
        /// The Client Drive Mapping Service Has Disconnected on Terminal Connection.
        /// </summary>
        ERROR_CTX_CDM_DISCONNECT = 7067, // 0x00001B9B
        /// <summary>
        /// The Terminal Server security layer detected an error in the protocol stream and has disconnected the client.
        /// </summary>
        ERROR_CTX_SECURITY_LAYER_ERROR = 7068, // 0x00001B9C
        /// <summary>
        /// The target session is incompatible with the current session.
        /// </summary>
        ERROR_TS_INCOMPATIBLE_SESSIONS = 7069, // 0x00001B9D
        /// <summary>
        /// Windows can't connect to your session because a problem occurred in the Windows video subsystem. Try connecting again later, or contact the server administrator for assistance.
        /// </summary>
        ERROR_TS_VIDEO_SUBSYSTEM_ERROR = 7070, // 0x00001B9E
        /// <summary>
        /// The file replication service API was called incorrectly.
        /// </summary>
        FRS_ERR_INVALID_API_SEQUENCE = 8001, // 0x00001F41
        /// <summary>The file replication service cannot be started.</summary>
        FRS_ERR_STARTING_SERVICE = 8002, // 0x00001F42
        /// <summary>The file replication service cannot be stopped.</summary>
        FRS_ERR_STOPPING_SERVICE = 8003, // 0x00001F43
        /// <summary>
        /// The file replication service API terminated the request. The event log may have more information.
        /// </summary>
        FRS_ERR_INTERNAL_API = 8004, // 0x00001F44
        /// <summary>
        /// The file replication service terminated the request. The event log may have more information.
        /// </summary>
        FRS_ERR_INTERNAL = 8005, // 0x00001F45
        /// <summary>
        /// The file replication service cannot be contacted. The event log may have more information.
        /// </summary>
        FRS_ERR_SERVICE_COMM = 8006, // 0x00001F46
        /// <summary>
        /// The file replication service cannot satisfy the request because the user has insufficient privileges. The event log may have more information.
        /// </summary>
        FRS_ERR_INSUFFICIENT_PRIV = 8007, // 0x00001F47
        /// <summary>
        /// The file replication service cannot satisfy the request because authenticated RPC is not available. The event log may have more information.
        /// </summary>
        FRS_ERR_AUTHENTICATION = 8008, // 0x00001F48
        /// <summary>
        /// The file replication service cannot satisfy the request because the user has insufficient privileges on the domain controller. The event log may have more information.
        /// </summary>
        FRS_ERR_PARENT_INSUFFICIENT_PRIV = 8009, // 0x00001F49
        /// <summary>
        /// The file replication service cannot satisfy the request because authenticated RPC is not available on the domain controller. The event log may have more information.
        /// </summary>
        FRS_ERR_PARENT_AUTHENTICATION = 8010, // 0x00001F4A
        /// <summary>
        /// The file replication service cannot communicate with the file replication service on the domain controller. The event log may have more information.
        /// </summary>
        FRS_ERR_CHILD_TO_PARENT_COMM = 8011, // 0x00001F4B
        /// <summary>
        /// The file replication service on the domain controller cannot communicate with the file replication service on this computer. The event log may have more information.
        /// </summary>
        FRS_ERR_PARENT_TO_CHILD_COMM = 8012, // 0x00001F4C
        /// <summary>
        /// The file replication service cannot populate the system volume because of an internal error. The event log may have more information.
        /// </summary>
        FRS_ERR_SYSVOL_POPULATE = 8013, // 0x00001F4D
        /// <summary>
        /// The file replication service cannot populate the system volume because of an internal timeout. The event log may have more information.
        /// </summary>
        FRS_ERR_SYSVOL_POPULATE_TIMEOUT = 8014, // 0x00001F4E
        /// <summary>
        /// The file replication service cannot process the request. The system volume is busy with a previous request.
        /// </summary>
        FRS_ERR_SYSVOL_IS_BUSY = 8015, // 0x00001F4F
        /// <summary>
        /// The file replication service cannot stop replicating the system volume because of an internal error. The event log may have more information.
        /// </summary>
        FRS_ERR_SYSVOL_DEMOTE = 8016, // 0x00001F50
        /// <summary>
        /// The file replication service detected an invalid parameter.
        /// </summary>
        FRS_ERR_INVALID_SERVICE_PARAMETER = 8017, // 0x00001F51
        /// <summary>
        /// An error occurred while installing the directory service. For more information, see the event log.
        /// </summary>
        ERROR_DS_NOT_INSTALLED = 8200, // 0x00002008
        /// <summary>
        /// The directory service evaluated group memberships locally.
        /// </summary>
        ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY = 8201, // 0x00002009
        /// <summary>
        /// The specified directory service attribute or value does not exist.
        /// </summary>
        ERROR_DS_NO_ATTRIBUTE_OR_VALUE = 8202, // 0x0000200A
        /// <summary>
        /// The attribute syntax specified to the directory service is invalid.
        /// </summary>
        ERROR_DS_INVALID_ATTRIBUTE_SYNTAX = 8203, // 0x0000200B
        /// <summary>
        /// The attribute type specified to the directory service is not defined.
        /// </summary>
        ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED = 8204, // 0x0000200C
        /// <summary>
        /// The specified directory service attribute or value already exists.
        /// </summary>
        ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS = 8205, // 0x0000200D
        /// <summary>The directory service is busy.</summary>
        ERROR_DS_BUSY = 8206, // 0x0000200E
        /// <summary>The directory service is unavailable.</summary>
        ERROR_DS_UNAVAILABLE = 8207, // 0x0000200F
        /// <summary>
        /// The directory service was unable to allocate a relative identifier.
        /// </summary>
        ERROR_DS_NO_RIDS_ALLOCATED = 8208, // 0x00002010
        /// <summary>
        /// The directory service has exhausted the pool of relative identifiers.
        /// </summary>
        ERROR_DS_NO_MORE_RIDS = 8209, // 0x00002011
        /// <summary>
        /// The requested operation could not be performed because the directory service is not the master for that type of operation.
        /// </summary>
        ERROR_DS_INCORRECT_ROLE_OWNER = 8210, // 0x00002012
        /// <summary>
        /// The directory service was unable to initialize the subsystem that allocates relative identifiers.
        /// </summary>
        ERROR_DS_RIDMGR_INIT_ERROR = 8211, // 0x00002013
        /// <summary>
        /// The requested operation did not satisfy one or more constraints associated with the class of the object.
        /// </summary>
        ERROR_DS_OBJ_CLASS_VIOLATION = 8212, // 0x00002014
        /// <summary>
        /// The directory service can perform the requested operation only on a leaf object.
        /// </summary>
        ERROR_DS_CANT_ON_NON_LEAF = 8213, // 0x00002015
        /// <summary>
        /// The directory service cannot perform the requested operation on the RDN attribute of an object.
        /// </summary>
        ERROR_DS_CANT_ON_RDN = 8214, // 0x00002016
        /// <summary>
        /// The directory service detected an attempt to modify the object class of an object.
        /// </summary>
        ERROR_DS_CANT_MOD_OBJ_CLASS = 8215, // 0x00002017
        /// <summary>
        /// The requested cross-domain move operation could not be performed.
        /// </summary>
        ERROR_DS_CROSS_DOM_MOVE_ERROR = 8216, // 0x00002018
        /// <summary>Unable to contact the global catalog server.</summary>
        ERROR_DS_GC_NOT_AVAILABLE = 8217, // 0x00002019
        /// <summary>
        /// The policy object is shared and can only be modified at the root.
        /// </summary>
        ERROR_SHARED_POLICY = 8218, // 0x0000201A
        /// <summary>The policy object does not exist.</summary>
        ERROR_POLICY_OBJECT_NOT_FOUND = 8219, // 0x0000201B
        /// <summary>
        /// The requested policy information is only in the directory service.
        /// </summary>
        ERROR_POLICY_ONLY_IN_DS = 8220, // 0x0000201C
        /// <summary>A domain controller promotion is currently active.</summary>
        ERROR_PROMOTION_ACTIVE = 8221, // 0x0000201D
        /// <summary>
        /// A domain controller promotion is not currently active.
        /// </summary>
        ERROR_NO_PROMOTION_ACTIVE = 8222, // 0x0000201E
        /// <summary>An operations error occurred.</summary>
        ERROR_DS_OPERATIONS_ERROR = 8224, // 0x00002020
        /// <summary>A protocol error occurred.</summary>
        ERROR_DS_PROTOCOL_ERROR = 8225, // 0x00002021
        /// <summary>The time limit for this request was exceeded.</summary>
        ERROR_DS_TIMELIMIT_EXCEEDED = 8226, // 0x00002022
        /// <summary>The size limit for this request was exceeded.</summary>
        ERROR_DS_SIZELIMIT_EXCEEDED = 8227, // 0x00002023
        /// <summary>
        /// The administrative limit for this request was exceeded.
        /// </summary>
        ERROR_DS_ADMIN_LIMIT_EXCEEDED = 8228, // 0x00002024
        /// <summary>The compare response was false.</summary>
        ERROR_DS_COMPARE_FALSE = 8229, // 0x00002025
        /// <summary>The compare response was true.</summary>
        ERROR_DS_COMPARE_TRUE = 8230, // 0x00002026
        /// <summary>
        /// The requested authentication method is not supported by the server.
        /// </summary>
        ERROR_DS_AUTH_METHOD_NOT_SUPPORTED = 8231, // 0x00002027
        /// <summary>
        /// A more secure authentication method is required for this server.
        /// </summary>
        ERROR_DS_STRONG_AUTH_REQUIRED = 8232, // 0x00002028
        /// <summary>Inappropriate authentication.</summary>
        ERROR_DS_INAPPROPRIATE_AUTH = 8233, // 0x00002029
        /// <summary>The authentication mechanism is unknown.</summary>
        ERROR_DS_AUTH_UNKNOWN = 8234, // 0x0000202A
        /// <summary>A referral was returned from the server.</summary>
        ERROR_DS_REFERRAL = 8235, // 0x0000202B
        /// <summary>
        /// The server does not support the requested critical extension.
        /// </summary>
        ERROR_DS_UNAVAILABLE_CRIT_EXTENSION = 8236, // 0x0000202C
        /// <summary>This request requires a secure connection.</summary>
        ERROR_DS_CONFIDENTIALITY_REQUIRED = 8237, // 0x0000202D
        /// <summary>Inappropriate matching.</summary>
        ERROR_DS_INAPPROPRIATE_MATCHING = 8238, // 0x0000202E
        /// <summary>A constraint violation occurred.</summary>
        ERROR_DS_CONSTRAINT_VIOLATION = 8239, // 0x0000202F
        /// <summary>There is no such object on the server.</summary>
        ERROR_DS_NO_SUCH_OBJECT = 8240, // 0x00002030
        /// <summary>There is an alias problem.</summary>
        ERROR_DS_ALIAS_PROBLEM = 8241, // 0x00002031
        /// <summary>An invalid dn syntax has been specified.</summary>
        ERROR_DS_INVALID_DN_SYNTAX = 8242, // 0x00002032
        /// <summary>The object is a leaf object.</summary>
        ERROR_DS_IS_LEAF = 8243, // 0x00002033
        /// <summary>There is an alias dereferencing problem.</summary>
        ERROR_DS_ALIAS_DEREF_PROBLEM = 8244, // 0x00002034
        /// <summary>The server is unwilling to process the request.</summary>
        ERROR_DS_UNWILLING_TO_PERFORM = 8245, // 0x00002035
        /// <summary>A loop has been detected.</summary>
        ERROR_DS_LOOP_DETECT = 8246, // 0x00002036
        /// <summary>There is a naming violation.</summary>
        ERROR_DS_NAMING_VIOLATION = 8247, // 0x00002037
        /// <summary>The result set is too large.</summary>
        ERROR_DS_OBJECT_RESULTS_TOO_LARGE = 8248, // 0x00002038
        /// <summary>The operation affects multiple DSAs.</summary>
        ERROR_DS_AFFECTS_MULTIPLE_DSAS = 8249, // 0x00002039
        /// <summary>The server is not operational.</summary>
        ERROR_DS_SERVER_DOWN = 8250, // 0x0000203A
        /// <summary>A local error has occurred.</summary>
        ERROR_DS_LOCAL_ERROR = 8251, // 0x0000203B
        /// <summary>An encoding error has occurred.</summary>
        ERROR_DS_ENCODING_ERROR = 8252, // 0x0000203C
        /// <summary>A decoding error has occurred.</summary>
        ERROR_DS_DECODING_ERROR = 8253, // 0x0000203D
        /// <summary>The search filter cannot be recognized.</summary>
        ERROR_DS_FILTER_UNKNOWN = 8254, // 0x0000203E
        /// <summary>One or more parameters are illegal.</summary>
        ERROR_DS_PARAM_ERROR = 8255, // 0x0000203F
        /// <summary>The specified method is not supported.</summary>
        ERROR_DS_NOT_SUPPORTED = 8256, // 0x00002040
        /// <summary>No results were returned.</summary>
        ERROR_DS_NO_RESULTS_RETURNED = 8257, // 0x00002041
        /// <summary>The specified control is not supported by the server.</summary>
        ERROR_DS_CONTROL_NOT_FOUND = 8258, // 0x00002042
        /// <summary>A referral loop was detected by the client.</summary>
        ERROR_DS_CLIENT_LOOP = 8259, // 0x00002043
        /// <summary>The preset referral limit was exceeded.</summary>
        ERROR_DS_REFERRAL_LIMIT_EXCEEDED = 8260, // 0x00002044
        /// <summary>The search requires a SORT control.</summary>
        ERROR_DS_SORT_CONTROL_MISSING = 8261, // 0x00002045
        /// <summary>The search results exceed the offset range specified.</summary>
        ERROR_DS_OFFSET_RANGE_ERROR = 8262, // 0x00002046
        /// <summary>
        /// The directory service detected the subsystem that allocates relative identifiers is disabled. This can occur as a protective mechanism when the system determines a significant portion of relative identifiers (RIDs) have been exhausted. Please see http://go.microsoft.com/fwlink/p/?linkid=228610 for recommended diagnostic steps and the procedure to re-enable account creation.
        /// </summary>
        ERROR_DS_RIDMGR_DISABLED = 8263, // 0x00002047
        /// <summary>
        /// The root object must be the head of a naming context. The root object cannot have an instantiated parent.
        /// </summary>
        ERROR_DS_ROOT_MUST_BE_NC = 8301, // 0x0000206D
        /// <summary>
        /// The add replica operation cannot be performed. The naming context must be writeable in order to create the replica.
        /// </summary>
        ERROR_DS_ADD_REPLICA_INHIBITED = 8302, // 0x0000206E
        /// <summary>
        /// A reference to an attribute that is not defined in the schema occurred.
        /// </summary>
        ERROR_DS_ATT_NOT_DEF_IN_SCHEMA = 8303, // 0x0000206F
        /// <summary>The maximum size of an object has been exceeded.</summary>
        ERROR_DS_MAX_OBJ_SIZE_EXCEEDED = 8304, // 0x00002070
        /// <summary>
        /// An attempt was made to add an object to the directory with a name that is already in use.
        /// </summary>
        ERROR_DS_OBJ_STRING_NAME_EXISTS = 8305, // 0x00002071
        /// <summary>
        /// An attempt was made to add an object of a class that does not have an RDN defined in the schema.
        /// </summary>
        ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA = 8306, // 0x00002072
        /// <summary>
        /// An attempt was made to add an object using an RDN that is not the RDN defined in the schema.
        /// </summary>
        ERROR_DS_RDN_DOESNT_MATCH_SCHEMA = 8307, // 0x00002073
        /// <summary>
        /// None of the requested attributes were found on the objects.
        /// </summary>
        ERROR_DS_NO_REQUESTED_ATTS_FOUND = 8308, // 0x00002074
        /// <summary>The user buffer is too small.</summary>
        ERROR_DS_USER_BUFFER_TO_SMALL = 8309, // 0x00002075
        /// <summary>
        /// The attribute specified in the operation is not present on the object.
        /// </summary>
        ERROR_DS_ATT_IS_NOT_ON_OBJ = 8310, // 0x00002076
        /// <summary>
        /// Illegal modify operation. Some aspect of the modification is not permitted.
        /// </summary>
        ERROR_DS_ILLEGAL_MOD_OPERATION = 8311, // 0x00002077
        /// <summary>The specified object is too large.</summary>
        ERROR_DS_OBJ_TOO_LARGE = 8312, // 0x00002078
        /// <summary>The specified instance type is not valid.</summary>
        ERROR_DS_BAD_INSTANCE_TYPE = 8313, // 0x00002079
        /// <summary>The operation must be performed at a master DSA.</summary>
        ERROR_DS_MASTERDSA_REQUIRED = 8314, // 0x0000207A
        /// <summary>The object class attribute must be specified.</summary>
        ERROR_DS_OBJECT_CLASS_REQUIRED = 8315, // 0x0000207B
        /// <summary>A required attribute is missing.</summary>
        ERROR_DS_MISSING_REQUIRED_ATT = 8316, // 0x0000207C
        /// <summary>
        /// An attempt was made to modify an object to include an attribute that is not legal for its class.
        /// </summary>
        ERROR_DS_ATT_NOT_DEF_FOR_CLASS = 8317, // 0x0000207D
        /// <summary>
        /// The specified attribute is already present on the object.
        /// </summary>
        ERROR_DS_ATT_ALREADY_EXISTS = 8318, // 0x0000207E
        /// <summary>
        /// The specified attribute is not present, or has no values.
        /// </summary>
        ERROR_DS_CANT_ADD_ATT_VALUES = 8320, // 0x00002080
        /// <summary>
        /// Multiple values were specified for an attribute that can have only one value.
        /// </summary>
        ERROR_DS_SINGLE_VALUE_CONSTRAINT = 8321, // 0x00002081
        /// <summary>
        /// A value for the attribute was not in the acceptable range of values.
        /// </summary>
        ERROR_DS_RANGE_CONSTRAINT = 8322, // 0x00002082
        /// <summary>The specified value already exists.</summary>
        ERROR_DS_ATT_VAL_ALREADY_EXISTS = 8323, // 0x00002083
        /// <summary>
        /// The attribute cannot be removed because it is not present on the object.
        /// </summary>
        ERROR_DS_CANT_REM_MISSING_ATT = 8324, // 0x00002084
        /// <summary>
        /// The attribute value cannot be removed because it is not present on the object.
        /// </summary>
        ERROR_DS_CANT_REM_MISSING_ATT_VAL = 8325, // 0x00002085
        /// <summary>The specified root object cannot be a subref.</summary>
        ERROR_DS_ROOT_CANT_BE_SUBREF = 8326, // 0x00002086
        /// <summary>Chaining is not permitted.</summary>
        ERROR_DS_NO_CHAINING = 8327, // 0x00002087
        /// <summary>Chained evaluation is not permitted.</summary>
        ERROR_DS_NO_CHAINED_EVAL = 8328, // 0x00002088
        /// <summary>
        /// The operation could not be performed because the object's parent is either uninstantiated or deleted.
        /// </summary>
        ERROR_DS_NO_PARENT_OBJECT = 8329, // 0x00002089
        /// <summary>
        /// Having a parent that is an alias is not permitted. Aliases are leaf objects.
        /// </summary>
        ERROR_DS_PARENT_IS_AN_ALIAS = 8330, // 0x0000208A
        /// <summary>
        /// The object and parent must be of the same type, either both masters or both replicas.
        /// </summary>
        ERROR_DS_CANT_MIX_MASTER_AND_REPS = 8331, // 0x0000208B
        /// <summary>
        /// The operation cannot be performed because child objects exist. This operation can only be performed on a leaf object.
        /// </summary>
        ERROR_DS_CHILDREN_EXIST = 8332, // 0x0000208C
        /// <summary>Directory object not found.</summary>
        ERROR_DS_OBJ_NOT_FOUND = 8333, // 0x0000208D
        /// <summary>The aliased object is missing.</summary>
        ERROR_DS_ALIASED_OBJ_MISSING = 8334, // 0x0000208E
        /// <summary>The object name has bad syntax.</summary>
        ERROR_DS_BAD_NAME_SYNTAX = 8335, // 0x0000208F
        /// <summary>
        /// It is not permitted for an alias to refer to another alias.
        /// </summary>
        ERROR_DS_ALIAS_POINTS_TO_ALIAS = 8336, // 0x00002090
        /// <summary>The alias cannot be dereferenced.</summary>
        ERROR_DS_CANT_DEREF_ALIAS = 8337, // 0x00002091
        /// <summary>The operation is out of scope.</summary>
        ERROR_DS_OUT_OF_SCOPE = 8338, // 0x00002092
        /// <summary>
        /// The operation cannot continue because the object is in the process of being removed.
        /// </summary>
        ERROR_DS_OBJECT_BEING_REMOVED = 8339, // 0x00002093
        /// <summary>The DSA object cannot be deleted.</summary>
        ERROR_DS_CANT_DELETE_DSA_OBJ = 8340, // 0x00002094
        /// <summary>A directory service error has occurred.</summary>
        ERROR_DS_GENERIC_ERROR = 8341, // 0x00002095
        /// <summary>
        /// The operation can only be performed on an internal master DSA object.
        /// </summary>
        ERROR_DS_DSA_MUST_BE_INT_MASTER = 8342, // 0x00002096
        /// <summary>The object must be of class DSA.</summary>
        ERROR_DS_CLASS_NOT_DSA = 8343, // 0x00002097
        /// <summary>Insufficient access rights to perform the operation.</summary>
        ERROR_DS_INSUFF_ACCESS_RIGHTS = 8344, // 0x00002098
        /// <summary>
        /// The object cannot be added because the parent is not on the list of possible superiors.
        /// </summary>
        ERROR_DS_ILLEGAL_SUPERIOR = 8345, // 0x00002099
        /// <summary>
        /// Access to the attribute is not permitted because the attribute is owned by the Security Accounts Manager (SAM).
        /// </summary>
        ERROR_DS_ATTRIBUTE_OWNED_BY_SAM = 8346, // 0x0000209A
        /// <summary>The name has too many parts.</summary>
        ERROR_DS_NAME_TOO_MANY_PARTS = 8347, // 0x0000209B
        /// <summary>The name is too long.</summary>
        ERROR_DS_NAME_TOO_LONG = 8348, // 0x0000209C
        /// <summary>The name value is too long.</summary>
        ERROR_DS_NAME_VALUE_TOO_LONG = 8349, // 0x0000209D
        /// <summary>
        /// The directory service encountered an error parsing a name.
        /// </summary>
        ERROR_DS_NAME_UNPARSEABLE = 8350, // 0x0000209E
        /// <summary>
        /// The directory service cannot get the attribute type for a name.
        /// </summary>
        ERROR_DS_NAME_TYPE_UNKNOWN = 8351, // 0x0000209F
        /// <summary>
        /// The name does not identify an object; the name identifies a phantom.
        /// </summary>
        ERROR_DS_NOT_AN_OBJECT = 8352, // 0x000020A0
        /// <summary>The security descriptor is too short.</summary>
        ERROR_DS_SEC_DESC_TOO_SHORT = 8353, // 0x000020A1
        /// <summary>The security descriptor is invalid.</summary>
        ERROR_DS_SEC_DESC_INVALID = 8354, // 0x000020A2
        /// <summary>Failed to create name for deleted object.</summary>
        ERROR_DS_NO_DELETED_NAME = 8355, // 0x000020A3
        /// <summary>The parent of a new subref must exist.</summary>
        ERROR_DS_SUBREF_MUST_HAVE_PARENT = 8356, // 0x000020A4
        /// <summary>The object must be a naming context.</summary>
        ERROR_DS_NCNAME_MUST_BE_NC = 8357, // 0x000020A5
        /// <summary>
        /// It is not permitted to add an attribute which is owned by the system.
        /// </summary>
        ERROR_DS_CANT_ADD_SYSTEM_ONLY = 8358, // 0x000020A6
        /// <summary>
        /// The class of the object must be structural; you cannot instantiate an abstract class.
        /// </summary>
        ERROR_DS_CLASS_MUST_BE_CONCRETE = 8359, // 0x000020A7
        /// <summary>The schema object could not be found.</summary>
        ERROR_DS_INVALID_DMD = 8360, // 0x000020A8
        /// <summary>
        /// A local object with this GUID (dead or alive) already exists.
        /// </summary>
        ERROR_DS_OBJ_GUID_EXISTS = 8361, // 0x000020A9
        /// <summary>The operation cannot be performed on a back link.</summary>
        ERROR_DS_NOT_ON_BACKLINK = 8362, // 0x000020AA
        /// <summary>
        /// The cross reference for the specified naming context could not be found.
        /// </summary>
        ERROR_DS_NO_CROSSREF_FOR_NC = 8363, // 0x000020AB
        /// <summary>
        /// The operation could not be performed because the directory service is shutting down.
        /// </summary>
        ERROR_DS_SHUTTING_DOWN = 8364, // 0x000020AC
        /// <summary>The directory service request is invalid.</summary>
        ERROR_DS_UNKNOWN_OPERATION = 8365, // 0x000020AD
        /// <summary>The role owner attribute could not be read.</summary>
        ERROR_DS_INVALID_ROLE_OWNER = 8366, // 0x000020AE
        /// <summary>
        /// The requested FSMO operation failed. The current FSMO holder could not be contacted.
        /// </summary>
        ERROR_DS_COULDNT_CONTACT_FSMO = 8367, // 0x000020AF
        /// <summary>
        /// Modification of a DN across a naming context is not permitted.
        /// </summary>
        ERROR_DS_CROSS_NC_DN_RENAME = 8368, // 0x000020B0
        /// <summary>
        /// The attribute cannot be modified because it is owned by the system.
        /// </summary>
        ERROR_DS_CANT_MOD_SYSTEM_ONLY = 8369, // 0x000020B1
        /// <summary>Only the replicator can perform this function.</summary>
        ERROR_DS_REPLICATOR_ONLY = 8370, // 0x000020B2
        /// <summary>The specified class is not defined.</summary>
        ERROR_DS_OBJ_CLASS_NOT_DEFINED = 8371, // 0x000020B3
        /// <summary>The specified class is not a subclass.</summary>
        ERROR_DS_OBJ_CLASS_NOT_SUBCLASS = 8372, // 0x000020B4
        /// <summary>The name reference is invalid.</summary>
        ERROR_DS_NAME_REFERENCE_INVALID = 8373, // 0x000020B5
        /// <summary>A cross reference already exists.</summary>
        ERROR_DS_CROSS_REF_EXISTS = 8374, // 0x000020B6
        /// <summary>
        /// It is not permitted to delete a master cross reference.
        /// </summary>
        ERROR_DS_CANT_DEL_MASTER_CROSSREF = 8375, // 0x000020B7
        /// <summary>Subtree notifications are only supported on NC heads.</summary>
        ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD = 8376, // 0x000020B8
        /// <summary>Notification filter is too complex.</summary>
        ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX = 8377, // 0x000020B9
        /// <summary>Schema update failed: duplicate RDN.</summary>
        ERROR_DS_DUP_RDN = 8378, // 0x000020BA
        /// <summary>Schema update failed: duplicate OID.</summary>
        ERROR_DS_DUP_OID = 8379, // 0x000020BB
        /// <summary>Schema update failed: duplicate MAPI identifier.</summary>
        ERROR_DS_DUP_MAPI_ID = 8380, // 0x000020BC
        /// <summary>Schema update failed: duplicate schema-id GUID.</summary>
        ERROR_DS_DUP_SCHEMA_ID_GUID = 8381, // 0x000020BD
        /// <summary>Schema update failed: duplicate LDAP display name.</summary>
        ERROR_DS_DUP_LDAP_DISPLAY_NAME = 8382, // 0x000020BE
        /// <summary>
        /// Schema update failed: range-lower less than range upper.
        /// </summary>
        ERROR_DS_SEMANTIC_ATT_TEST = 8383, // 0x000020BF
        /// <summary>Schema update failed: syntax mismatch.</summary>
        ERROR_DS_SYNTAX_MISMATCH = 8384, // 0x000020C0
        /// <summary>
        /// Schema deletion failed: attribute is used in must-contain.
        /// </summary>
        ERROR_DS_EXISTS_IN_MUST_HAVE = 8385, // 0x000020C1
        /// <summary>
        /// Schema deletion failed: attribute is used in may-contain.
        /// </summary>
        ERROR_DS_EXISTS_IN_MAY_HAVE = 8386, // 0x000020C2
        /// <summary>
        /// Schema update failed: attribute in may-contain does not exist.
        /// </summary>
        ERROR_DS_NONEXISTENT_MAY_HAVE = 8387, // 0x000020C3
        /// <summary>
        /// Schema update failed: attribute in must-contain does not exist.
        /// </summary>
        ERROR_DS_NONEXISTENT_MUST_HAVE = 8388, // 0x000020C4
        /// <summary>
        /// Schema update failed: class in aux-class list does not exist or is not an auxiliary class.
        /// </summary>
        ERROR_DS_AUX_CLS_TEST_FAIL = 8389, // 0x000020C5
        /// <summary>
        /// Schema update failed: class in poss-superiors does not exist.
        /// </summary>
        ERROR_DS_NONEXISTENT_POSS_SUP = 8390, // 0x000020C6
        /// <summary>
        /// Schema update failed: class in subclassof list does not exist or does not satisfy hierarchy rules.
        /// </summary>
        ERROR_DS_SUB_CLS_TEST_FAIL = 8391, // 0x000020C7
        /// <summary>Schema update failed: Rdn-Att-Id has wrong syntax.</summary>
        ERROR_DS_BAD_RDN_ATT_ID_SYNTAX = 8392, // 0x000020C8
        /// <summary>
        /// Schema deletion failed: class is used as auxiliary class.
        /// </summary>
        ERROR_DS_EXISTS_IN_AUX_CLS = 8393, // 0x000020C9
        /// <summary>Schema deletion failed: class is used as sub class.</summary>
        ERROR_DS_EXISTS_IN_SUB_CLS = 8394, // 0x000020CA
        /// <summary>
        /// Schema deletion failed: class is used as poss superior.
        /// </summary>
        ERROR_DS_EXISTS_IN_POSS_SUP = 8395, // 0x000020CB
        /// <summary>
        /// Schema update failed in recalculating validation cache.
        /// </summary>
        ERROR_DS_RECALCSCHEMA_FAILED = 8396, // 0x000020CC
        /// <summary>
        /// The tree deletion is not finished. The request must be made again to continue deleting the tree.
        /// </summary>
        ERROR_DS_TREE_DELETE_NOT_FINISHED = 8397, // 0x000020CD
        /// <summary>
        /// The requested delete operation could not be performed.
        /// </summary>
        ERROR_DS_CANT_DELETE = 8398, // 0x000020CE
        /// <summary>
        /// Cannot read the governs class identifier for the schema record.
        /// </summary>
        ERROR_DS_ATT_SCHEMA_REQ_ID = 8399, // 0x000020CF
        /// <summary>The attribute schema has bad syntax.</summary>
        ERROR_DS_BAD_ATT_SCHEMA_SYNTAX = 8400, // 0x000020D0
        /// <summary>The attribute could not be cached.</summary>
        ERROR_DS_CANT_CACHE_ATT = 8401, // 0x000020D1
        /// <summary>The class could not be cached.</summary>
        ERROR_DS_CANT_CACHE_CLASS = 8402, // 0x000020D2
        /// <summary>The attribute could not be removed from the cache.</summary>
        ERROR_DS_CANT_REMOVE_ATT_CACHE = 8403, // 0x000020D3
        /// <summary>The class could not be removed from the cache.</summary>
        ERROR_DS_CANT_REMOVE_CLASS_CACHE = 8404, // 0x000020D4
        /// <summary>The distinguished name attribute could not be read.</summary>
        ERROR_DS_CANT_RETRIEVE_DN = 8405, // 0x000020D5
        /// <summary>
        /// No superior reference has been configured for the directory service. The directory service is therefore unable to issue referrals to objects outside this forest.
        /// </summary>
        ERROR_DS_MISSING_SUPREF = 8406, // 0x000020D6
        /// <summary>The instance type attribute could not be retrieved.</summary>
        ERROR_DS_CANT_RETRIEVE_INSTANCE = 8407, // 0x000020D7
        /// <summary>An internal error has occurred.</summary>
        ERROR_DS_CODE_INCONSISTENCY = 8408, // 0x000020D8
        /// <summary>A database error has occurred.</summary>
        ERROR_DS_DATABASE_ERROR = 8409, // 0x000020D9
        /// <summary>The attribute GOVERNSID is missing.</summary>
        ERROR_DS_GOVERNSID_MISSING = 8410, // 0x000020DA
        /// <summary>An expected attribute is missing.</summary>
        ERROR_DS_MISSING_EXPECTED_ATT = 8411, // 0x000020DB
        /// <summary>
        /// The specified naming context is missing a cross reference.
        /// </summary>
        ERROR_DS_NCNAME_MISSING_CR_REF = 8412, // 0x000020DC
        /// <summary>A security checking error has occurred.</summary>
        ERROR_DS_SECURITY_CHECKING_ERROR = 8413, // 0x000020DD
        /// <summary>The schema is not loaded.</summary>
        ERROR_DS_SCHEMA_NOT_LOADED = 8414, // 0x000020DE
        /// <summary>
        /// Schema allocation failed. Please check if the machine is running low on memory.
        /// </summary>
        ERROR_DS_SCHEMA_ALLOC_FAILED = 8415, // 0x000020DF
        /// <summary>
        /// Failed to obtain the required syntax for the attribute schema.
        /// </summary>
        ERROR_DS_ATT_SCHEMA_REQ_SYNTAX = 8416, // 0x000020E0
        /// <summary>
        /// The global catalog verification failed. The global catalog is not available or does not support the operation. Some part of the directory is currently not available.
        /// </summary>
        ERROR_DS_GCVERIFY_ERROR = 8417, // 0x000020E1
        /// <summary>
        /// The replication operation failed because of a schema mismatch between the servers involved.
        /// </summary>
        ERROR_DS_DRA_SCHEMA_MISMATCH = 8418, // 0x000020E2
        /// <summary>The DSA object could not be found.</summary>
        ERROR_DS_CANT_FIND_DSA_OBJ = 8419, // 0x000020E3
        /// <summary>The naming context could not be found.</summary>
        ERROR_DS_CANT_FIND_EXPECTED_NC = 8420, // 0x000020E4
        /// <summary>The naming context could not be found in the cache.</summary>
        ERROR_DS_CANT_FIND_NC_IN_CACHE = 8421, // 0x000020E5
        /// <summary>The child object could not be retrieved.</summary>
        ERROR_DS_CANT_RETRIEVE_CHILD = 8422, // 0x000020E6
        /// <summary>
        /// The modification was not permitted for security reasons.
        /// </summary>
        ERROR_DS_SECURITY_ILLEGAL_MODIFY = 8423, // 0x000020E7
        /// <summary>The operation cannot replace the hidden record.</summary>
        ERROR_DS_CANT_REPLACE_HIDDEN_REC = 8424, // 0x000020E8
        /// <summary>The hierarchy file is invalid.</summary>
        ERROR_DS_BAD_HIERARCHY_FILE = 8425, // 0x000020E9
        /// <summary>The attempt to build the hierarchy table failed.</summary>
        ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED = 8426, // 0x000020EA
        /// <summary>
        /// The directory configuration parameter is missing from the registry.
        /// </summary>
        ERROR_DS_CONFIG_PARAM_MISSING = 8427, // 0x000020EB
        /// <summary>The attempt to count the address book indices failed.</summary>
        ERROR_DS_COUNTING_AB_INDICES_FAILED = 8428, // 0x000020EC
        /// <summary>The allocation of the hierarchy table failed.</summary>
        ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED = 8429, // 0x000020ED
        /// <summary>
        /// The directory service encountered an internal failure.
        /// </summary>
        ERROR_DS_INTERNAL_FAILURE = 8430, // 0x000020EE
        /// <summary>The directory service encountered an unknown failure.</summary>
        ERROR_DS_UNKNOWN_ERROR = 8431, // 0x000020EF
        /// <summary>A root object requires a class of 'top'.</summary>
        ERROR_DS_ROOT_REQUIRES_CLASS_TOP = 8432, // 0x000020F0
        /// <summary>
        /// This directory server is shutting down, and cannot take ownership of new floating single-master operation roles.
        /// </summary>
        ERROR_DS_REFUSING_FSMO_ROLES = 8433, // 0x000020F1
        /// <summary>
        /// The directory service is missing mandatory configuration information, and is unable to determine the ownership of floating single-master operation roles.
        /// </summary>
        ERROR_DS_MISSING_FSMO_SETTINGS = 8434, // 0x000020F2
        /// <summary>
        /// The directory service was unable to transfer ownership of one or more floating single-master operation roles to other servers.
        /// </summary>
        ERROR_DS_UNABLE_TO_SURRENDER_ROLES = 8435, // 0x000020F3
        /// <summary>The replication operation failed.</summary>
        ERROR_DS_DRA_GENERIC = 8436, // 0x000020F4
        /// <summary>
        /// An invalid parameter was specified for this replication operation.
        /// </summary>
        ERROR_DS_DRA_INVALID_PARAMETER = 8437, // 0x000020F5
        /// <summary>
        /// The directory service is too busy to complete the replication operation at this time.
        /// </summary>
        ERROR_DS_DRA_BUSY = 8438, // 0x000020F6
        /// <summary>
        /// The distinguished name specified for this replication operation is invalid.
        /// </summary>
        ERROR_DS_DRA_BAD_DN = 8439, // 0x000020F7
        /// <summary>
        /// The naming context specified for this replication operation is invalid.
        /// </summary>
        ERROR_DS_DRA_BAD_NC = 8440, // 0x000020F8
        /// <summary>
        /// The distinguished name specified for this replication operation already exists.
        /// </summary>
        ERROR_DS_DRA_DN_EXISTS = 8441, // 0x000020F9
        /// <summary>The replication system encountered an internal error.</summary>
        ERROR_DS_DRA_INTERNAL_ERROR = 8442, // 0x000020FA
        /// <summary>
        /// The replication operation encountered a database inconsistency.
        /// </summary>
        ERROR_DS_DRA_INCONSISTENT_DIT = 8443, // 0x000020FB
        /// <summary>
        /// The server specified for this replication operation could not be contacted.
        /// </summary>
        ERROR_DS_DRA_CONNECTION_FAILED = 8444, // 0x000020FC
        /// <summary>
        /// The replication operation encountered an object with an invalid instance type.
        /// </summary>
        ERROR_DS_DRA_BAD_INSTANCE_TYPE = 8445, // 0x000020FD
        /// <summary>The replication operation failed to allocate memory.</summary>
        ERROR_DS_DRA_OUT_OF_MEM = 8446, // 0x000020FE
        /// <summary>
        /// The replication operation encountered an error with the mail system.
        /// </summary>
        ERROR_DS_DRA_MAIL_PROBLEM = 8447, // 0x000020FF
        /// <summary>
        /// The replication reference information for the target server already exists.
        /// </summary>
        ERROR_DS_DRA_REF_ALREADY_EXISTS = 8448, // 0x00002100
        /// <summary>
        /// The replication reference information for the target server does not exist.
        /// </summary>
        ERROR_DS_DRA_REF_NOT_FOUND = 8449, // 0x00002101
        /// <summary>
        /// The naming context cannot be removed because it is replicated to another server.
        /// </summary>
        ERROR_DS_DRA_OBJ_IS_REP_SOURCE = 8450, // 0x00002102
        /// <summary>
        /// The replication operation encountered a database error.
        /// </summary>
        ERROR_DS_DRA_DB_ERROR = 8451, // 0x00002103
        /// <summary>
        /// The naming context is in the process of being removed or is not replicated from the specified server.
        /// </summary>
        ERROR_DS_DRA_NO_REPLICA = 8452, // 0x00002104
        /// <summary>Replication access was denied.</summary>
        ERROR_DS_DRA_ACCESS_DENIED = 8453, // 0x00002105
        /// <summary>
        /// The requested operation is not supported by this version of the directory service.
        /// </summary>
        ERROR_DS_DRA_NOT_SUPPORTED = 8454, // 0x00002106
        /// <summary>The replication remote procedure call was cancelled.</summary>
        ERROR_DS_DRA_RPC_CANCELLED = 8455, // 0x00002107
        /// <summary>
        /// The source server is currently rejecting replication requests.
        /// </summary>
        ERROR_DS_DRA_SOURCE_DISABLED = 8456, // 0x00002108
        /// <summary>
        /// The destination server is currently rejecting replication requests.
        /// </summary>
        ERROR_DS_DRA_SINK_DISABLED = 8457, // 0x00002109
        /// <summary>
        /// The replication operation failed due to a collision of object names.
        /// </summary>
        ERROR_DS_DRA_NAME_COLLISION = 8458, // 0x0000210A
        /// <summary>The replication source has been reinstalled.</summary>
        ERROR_DS_DRA_SOURCE_REINSTALLED = 8459, // 0x0000210B
        /// <summary>
        /// The replication operation failed because a required parent object is missing.
        /// </summary>
        ERROR_DS_DRA_MISSING_PARENT = 8460, // 0x0000210C
        /// <summary>The replication operation was preempted.</summary>
        ERROR_DS_DRA_PREEMPTED = 8461, // 0x0000210D
        /// <summary>
        /// The replication synchronization attempt was abandoned because of a lack of updates.
        /// </summary>
        ERROR_DS_DRA_ABANDON_SYNC = 8462, // 0x0000210E
        /// <summary>
        /// The replication operation was terminated because the system is shutting down.
        /// </summary>
        ERROR_DS_DRA_SHUTDOWN = 8463, // 0x0000210F
        /// <summary>
        /// Synchronization attempt failed because the destination DC is currently waiting to synchronize new partial attributes from source. This condition is normal if a recent schema change modified the partial attribute set. The destination partial attribute set is not a subset of source partial attribute set.
        /// </summary>
        ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET = 8464, // 0x00002110
        /// <summary>
        /// The replication synchronization attempt failed because a master replica attempted to sync from a partial replica.
        /// </summary>
        ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA = 8465, // 0x00002111
        /// <summary>
        /// The server specified for this replication operation was contacted, but that server was unable to contact an additional server needed to complete the operation.
        /// </summary>
        ERROR_DS_DRA_EXTN_CONNECTION_FAILED = 8466, // 0x00002112
        /// <summary>
        /// The version of the directory service schema of the source forest is not compatible with the version of directory service on this computer.
        /// </summary>
        ERROR_DS_INSTALL_SCHEMA_MISMATCH = 8467, // 0x00002113
        /// <summary>
        /// Schema update failed: An attribute with the same link identifier already exists.
        /// </summary>
        ERROR_DS_DUP_LINK_ID = 8468, // 0x00002114
        /// <summary>Name translation: Generic processing error.</summary>
        ERROR_DS_NAME_ERROR_RESOLVING = 8469, // 0x00002115
        /// <summary>
        /// Name translation: Could not find the name or insufficient right to see name.
        /// </summary>
        ERROR_DS_NAME_ERROR_NOT_FOUND = 8470, // 0x00002116
        /// <summary>
        /// Name translation: Input name mapped to more than one output name.
        /// </summary>
        ERROR_DS_NAME_ERROR_NOT_UNIQUE = 8471, // 0x00002117
        /// <summary>
        /// Name translation: Input name found, but not the associated output format.
        /// </summary>
        ERROR_DS_NAME_ERROR_NO_MAPPING = 8472, // 0x00002118
        /// <summary>
        /// Name translation: Unable to resolve completely, only the domain was found.
        /// </summary>
        ERROR_DS_NAME_ERROR_DOMAIN_ONLY = 8473, // 0x00002119
        /// <summary>
        /// Name translation: Unable to perform purely syntactical mapping at the client without going out to the wire.
        /// </summary>
        ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING = 8474, // 0x0000211A
        /// <summary>
        /// Modification of a constructed attribute is not allowed.
        /// </summary>
        ERROR_DS_CONSTRUCTED_ATT_MOD = 8475, // 0x0000211B
        /// <summary>
        /// The OM-Object-Class specified is incorrect for an attribute with the specified syntax.
        /// </summary>
        ERROR_DS_WRONG_OM_OBJ_CLASS = 8476, // 0x0000211C
        /// <summary>
        /// The replication request has been posted; waiting for reply.
        /// </summary>
        ERROR_DS_DRA_REPL_PENDING = 8477, // 0x0000211D
        /// <summary>
        /// The requested operation requires a directory service, and none was available.
        /// </summary>
        ERROR_DS_DS_REQUIRED = 8478, // 0x0000211E
        /// <summary>
        /// The LDAP display name of the class or attribute contains non-ASCII characters.
        /// </summary>
        ERROR_DS_INVALID_LDAP_DISPLAY_NAME = 8479, // 0x0000211F
        /// <summary>
        /// The requested search operation is only supported for base searches.
        /// </summary>
        ERROR_DS_NON_BASE_SEARCH = 8480, // 0x00002120
        /// <summary>
        /// The search failed to retrieve attributes from the database.
        /// </summary>
        ERROR_DS_CANT_RETRIEVE_ATTS = 8481, // 0x00002121
        /// <summary>
        /// The schema update operation tried to add a backward link attribute that has no corresponding forward link.
        /// </summary>
        ERROR_DS_BACKLINK_WITHOUT_LINK = 8482, // 0x00002122
        /// <summary>
        /// Source and destination of a cross-domain move do not agree on the object's epoch number. Either source or destination does not have the latest version of the object.
        /// </summary>
        ERROR_DS_EPOCH_MISMATCH = 8483, // 0x00002123
        /// <summary>
        /// Source and destination of a cross-domain move do not agree on the object's current name. Either source or destination does not have the latest version of the object.
        /// </summary>
        ERROR_DS_SRC_NAME_MISMATCH = 8484, // 0x00002124
        /// <summary>
        /// Source and destination for the cross-domain move operation are identical. Caller should use local move operation instead of cross-domain move operation.
        /// </summary>
        ERROR_DS_SRC_AND_DST_NC_IDENTICAL = 8485, // 0x00002125
        /// <summary>
        /// Source and destination for a cross-domain move are not in agreement on the naming contexts in the forest. Either source or destination does not have the latest version of the Partitions container.
        /// </summary>
        ERROR_DS_DST_NC_MISMATCH = 8486, // 0x00002126
        /// <summary>
        /// Destination of a cross-domain move is not authoritative for the destination naming context.
        /// </summary>
        ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC = 8487, // 0x00002127
        /// <summary>
        /// Source and destination of a cross-domain move do not agree on the identity of the source object. Either source or destination does not have the latest version of the source object.
        /// </summary>
        ERROR_DS_SRC_GUID_MISMATCH = 8488, // 0x00002128
        /// <summary>
        /// Object being moved across-domains is already known to be deleted by the destination server. The source server does not have the latest version of the source object.
        /// </summary>
        ERROR_DS_CANT_MOVE_DELETED_OBJECT = 8489, // 0x00002129
        /// <summary>
        /// Another operation which requires exclusive access to the PDC FSMO is already in progress.
        /// </summary>
        ERROR_DS_PDC_OPERATION_IN_PROGRESS = 8490, // 0x0000212A
        /// <summary>
        /// A cross-domain move operation failed such that two versions of the moved object exist - one each in the source and destination domains. The destination object needs to be removed to restore the system to a consistent state.
        /// </summary>
        ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD = 8491, // 0x0000212B
        /// <summary>
        /// This object may not be moved across domain boundaries either because cross-domain moves for this class are disallowed, or the object has some special characteristics, e.g.: trust account or restricted RID, which prevent its move.
        /// </summary>
        ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION = 8492, // 0x0000212C
        /// <summary>
        /// Can't move objects with memberships across domain boundaries as once moved, this would violate the membership conditions of the account group. Remove the object from any account group memberships and retry.
        /// </summary>
        ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS = 8493, // 0x0000212D
        /// <summary>
        /// A naming context head must be the immediate child of another naming context head, not of an interior node.
        /// </summary>
        ERROR_DS_NC_MUST_HAVE_NC_PARENT = 8494, // 0x0000212E
        /// <summary>
        /// The directory cannot validate the proposed naming context name because it does not hold a replica of the naming context above the proposed naming context. Please ensure that the domain naming master role is held by a server that is configured as a global catalog server, and that the server is up to date with its replication partners. (Applies only to Windows 2000 Domain Naming masters.)
        /// </summary>
        ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE = 8495, // 0x0000212F
        /// <summary>Destination domain must be in native mode.</summary>
        ERROR_DS_DST_DOMAIN_NOT_NATIVE = 8496, // 0x00002130
        /// <summary>
        /// The operation cannot be performed because the server does not have an infrastructure container in the domain of interest.
        /// </summary>
        ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER = 8497, // 0x00002131
        /// <summary>
        /// Cross-domain move of non-empty account groups is not allowed.
        /// </summary>
        ERROR_DS_CANT_MOVE_ACCOUNT_GROUP = 8498, // 0x00002132
        /// <summary>
        /// Cross-domain move of non-empty resource groups is not allowed.
        /// </summary>
        ERROR_DS_CANT_MOVE_RESOURCE_GROUP = 8499, // 0x00002133
        /// <summary>
        /// The search flags for the attribute are invalid. The ANR bit is valid only on attributes of Unicode or Teletex strings.
        /// </summary>
        ERROR_DS_INVALID_SEARCH_FLAG = 8500, // 0x00002134
        /// <summary>
        /// Tree deletions starting at an object which has an NC head as a descendant are not allowed.
        /// </summary>
        ERROR_DS_NO_TREE_DELETE_ABOVE_NC = 8501, // 0x00002135
        /// <summary>
        /// The directory service failed to lock a tree in preparation for a tree deletion because the tree was in use.
        /// </summary>
        ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE = 8502, // 0x00002136
        /// <summary>
        /// The directory service failed to identify the list of objects to delete while attempting a tree deletion.
        /// </summary>
        ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE = 8503, // 0x00002137
        /// <summary>
        /// Security Accounts Manager initialization failed because of the following error: %1. Error Status: 0x%2. Please shutdown this system and reboot into Directory Services Restore Mode, check the event log for more  detailed information.
        /// </summary>
        ERROR_DS_SAM_INIT_FAILURE = 8504, // 0x00002138
        /// <summary>
        /// Only an administrator can modify the membership list of an administrative group.
        /// </summary>
        ERROR_DS_SENSITIVE_GROUP_VIOLATION = 8505, // 0x00002139
        /// <summary>
        /// Cannot change the primary group ID of a domain controller account.
        /// </summary>
        ERROR_DS_CANT_MOD_PRIMARYGROUPID = 8506, // 0x0000213A
        /// <summary>An attempt is made to modify the base schema.</summary>
        ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD = 8507, // 0x0000213B
        /// <summary>
        /// Adding a new mandatory attribute to an existing class, deleting a mandatory attribute from an existing class, or adding an optional attribute to the special class Top that is not a backlink attribute (directly or  through inheritance, for example, by adding or deleting an auxiliary class) is not allowed.
        /// </summary>
        ERROR_DS_NONSAFE_SCHEMA_CHANGE = 8508, // 0x0000213C
        /// <summary>
        /// Schema update is not allowed on this DC because the DC is not the schema FSMO Role Owner.
        /// </summary>
        ERROR_DS_SCHEMA_UPDATE_DISALLOWED = 8509, // 0x0000213D
        /// <summary>
        /// An object of this class cannot be created under the schema container. You can only create attribute-schema and class-schema objects under the schema container.
        /// </summary>
        ERROR_DS_CANT_CREATE_UNDER_SCHEMA = 8510, // 0x0000213E
        /// <summary>
        /// The replica/child install failed to get the objectVersion attribute on the schema container on the source DC. Either the attribute is missing on the schema container or the credentials supplied do not have permission to read it.
        /// </summary>
        ERROR_DS_INSTALL_NO_SRC_SCH_VERSION = 8511, // 0x0000213F
        /// <summary>
        /// The replica/child install failed to read the objectVersion attribute in the SCHEMA section of the file schema.ini in the system32 directory.
        /// </summary>
        ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE = 8512, // 0x00002140
        /// <summary>The specified group type is invalid.</summary>
        ERROR_DS_INVALID_GROUP_TYPE = 8513, // 0x00002141
        /// <summary>
        /// You cannot nest global groups in a mixed domain if the group is security-enabled.
        /// </summary>
        ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN = 8514, // 0x00002142
        /// <summary>
        /// You cannot nest local groups in a mixed domain if the group is security-enabled.
        /// </summary>
        ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN = 8515, // 0x00002143
        /// <summary>A global group cannot have a local group as a member.</summary>
        ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER = 8516, // 0x00002144
        /// <summary>
        /// A global group cannot have a universal group as a member.
        /// </summary>
        ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER = 8517, // 0x00002145
        /// <summary>
        /// A universal group cannot have a local group as a member.
        /// </summary>
        ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER = 8518, // 0x00002146
        /// <summary>A global group cannot have a cross-domain member.</summary>
        ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER = 8519, // 0x00002147
        /// <summary>
        /// A local group cannot have another cross domain local group as a member.
        /// </summary>
        ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER = 8520, // 0x00002148
        /// <summary>
        /// A group with primary members cannot change to a security-disabled group.
        /// </summary>
        ERROR_DS_HAVE_PRIMARY_MEMBERS = 8521, // 0x00002149
        /// <summary>
        /// The schema cache load failed to convert the string default SD on a class-schema object.
        /// </summary>
        ERROR_DS_STRING_SD_CONVERSION_FAILED = 8522, // 0x0000214A
        /// <summary>
        /// Only DSAs configured to be Global Catalog servers should be allowed to hold the Domain Naming Master FSMO role. (Applies only to Windows 2000 servers.)
        /// </summary>
        ERROR_DS_NAMING_MASTER_GC = 8523, // 0x0000214B
        /// <summary>
        /// The DSA operation is unable to proceed because of a DNS lookup failure.
        /// </summary>
        ERROR_DS_DNS_LOOKUP_FAILURE = 8524, // 0x0000214C
        /// <summary>
        /// While processing a change to the DNS Host Name for an object, the Service Principal Name values could not be kept in sync.
        /// </summary>
        ERROR_DS_COULDNT_UPDATE_SPNS = 8525, // 0x0000214D
        /// <summary>The Security Descriptor attribute could not be read.</summary>
        ERROR_DS_CANT_RETRIEVE_SD = 8526, // 0x0000214E
        /// <summary>
        /// The object requested was not found, but an object with that key was found.
        /// </summary>
        ERROR_DS_KEY_NOT_UNIQUE = 8527, // 0x0000214F
        /// <summary>
        /// The syntax of the linked attribute being added is incorrect. Forward links can only have syntax 2.5.5.1, 2.5.5.7, and 2.5.5.14, and backlinks can only have syntax 2.5.5.1.
        /// </summary>
        ERROR_DS_WRONG_LINKED_ATT_SYNTAX = 8528, // 0x00002150
        /// <summary>
        /// Security Account Manager needs to get the boot password.
        /// </summary>
        ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD = 8529, // 0x00002151
        /// <summary>
        /// Security Account Manager needs to get the boot key from floppy disk.
        /// </summary>
        ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY = 8530, // 0x00002152
        /// <summary>Directory Service cannot start.</summary>
        ERROR_DS_CANT_START = 8531, // 0x00002153
        /// <summary>Directory Services could not start.</summary>
        ERROR_DS_INIT_FAILURE = 8532, // 0x00002154
        /// <summary>
        /// The connection between client and server requires packet privacy or better.
        /// </summary>
        ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION = 8533, // 0x00002155
        /// <summary>
        /// The source domain may not be in the same forest as destination.
        /// </summary>
        ERROR_DS_SOURCE_DOMAIN_IN_FOREST = 8534, // 0x00002156
        /// <summary>The destination domain must be in the forest.</summary>
        ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST = 8535, // 0x00002157
        /// <summary>
        /// The operation requires that destination domain auditing be enabled.
        /// </summary>
        ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED = 8536, // 0x00002158
        /// <summary>
        /// The operation couldn't locate a DC for the source domain.
        /// </summary>
        ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN = 8537, // 0x00002159
        /// <summary>The source object must be a group or user.</summary>
        ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER = 8538, // 0x0000215A
        /// <summary>
        /// The source object's SID already exists in destination forest.
        /// </summary>
        ERROR_DS_SRC_SID_EXISTS_IN_FOREST = 8539, // 0x0000215B
        /// <summary>
        /// The source and destination object must be of the same type.
        /// </summary>
        ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH = 8540, // 0x0000215C
        /// <summary>
        /// Security Accounts Manager initialization failed because of the following error: %1. Error Status: 0x%2. Click OK to shut down the system and reboot into Safe Mode. Check the event log for detailed information.
        /// </summary>
        ERROR_SAM_INIT_FAILURE = 8541, // 0x0000215D
        /// <summary>
        /// Schema information could not be included in the replication request.
        /// </summary>
        ERROR_DS_DRA_SCHEMA_INFO_SHIP = 8542, // 0x0000215E
        /// <summary>
        /// The replication operation could not be completed due to a schema incompatibility.
        /// </summary>
        ERROR_DS_DRA_SCHEMA_CONFLICT = 8543, // 0x0000215F
        /// <summary>
        /// The replication operation could not be completed due to a previous schema incompatibility.
        /// </summary>
        ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT = 8544, // 0x00002160
        /// <summary>
        /// The replication update could not be applied because either the source or the destination has not yet received information regarding a recent cross-domain move operation.
        /// </summary>
        ERROR_DS_DRA_OBJ_NC_MISMATCH = 8545, // 0x00002161
        /// <summary>
        /// The requested domain could not be deleted because there exist domain controllers that still host this domain.
        /// </summary>
        ERROR_DS_NC_STILL_HAS_DSAS = 8546, // 0x00002162
        /// <summary>
        /// The requested operation can be performed only on a global catalog server.
        /// </summary>
        ERROR_DS_GC_REQUIRED = 8547, // 0x00002163
        /// <summary>
        /// A local group can only be a member of other local groups in the same domain.
        /// </summary>
        ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY = 8548, // 0x00002164
        /// <summary>
        /// Foreign security principals cannot be members of universal groups.
        /// </summary>
        ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS = 8549, // 0x00002165
        /// <summary>
        /// The attribute is not allowed to be replicated to the GC because of security reasons.
        /// </summary>
        ERROR_DS_CANT_ADD_TO_GC = 8550, // 0x00002166
        /// <summary>
        /// The checkpoint with the PDC could not be taken because there too many modifications being processed currently.
        /// </summary>
        ERROR_DS_NO_CHECKPOINT_WITH_PDC = 8551, // 0x00002167
        /// <summary>
        /// The operation requires that source domain auditing be enabled.
        /// </summary>
        ERROR_DS_SOURCE_AUDITING_NOT_ENABLED = 8552, // 0x00002168
        /// <summary>
        /// Security principal objects can only be created inside domain naming contexts.
        /// </summary>
        ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC = 8553, // 0x00002169
        /// <summary>
        /// A Service Principal Name (SPN) could not be constructed because the provided hostname is not in the necessary format.
        /// </summary>
        ERROR_DS_INVALID_NAME_FOR_SPN = 8554, // 0x0000216A
        /// <summary>A Filter was passed that uses constructed attributes.</summary>
        ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS = 8555, // 0x0000216B
        /// <summary>
        /// The unicodePwd attribute value must be enclosed in double quotes.
        /// </summary>
        ERROR_DS_UNICODEPWD_NOT_IN_QUOTES = 8556, // 0x0000216C
        /// <summary>
        /// Your computer could not be joined to the domain. You have exceeded the maximum number of computer accounts you are allowed to create in this domain. Contact your system administrator to have this limit reset or increased.
        /// </summary>
        ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED = 8557, // 0x0000216D
        /// <summary>
        /// For security reasons, the operation must be run on the destination DC.
        /// </summary>
        ERROR_DS_MUST_BE_RUN_ON_DST_DC = 8558, // 0x0000216E
        /// <summary>
        /// For security reasons, the source DC must be NT4SP4 or greater.
        /// </summary>
        ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER = 8559, // 0x0000216F
        /// <summary>
        /// Critical Directory Service System objects cannot be deleted during tree delete operations. The tree delete may have been partially performed.
        /// </summary>
        ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ = 8560, // 0x00002170
        /// <summary>
        /// Directory Services could not start because of the following error: %1. Error Status: 0x%2. Please click OK to shutdown the system. You can use the recovery console to diagnose the system further.
        /// </summary>
        ERROR_DS_INIT_FAILURE_CONSOLE = 8561, // 0x00002171
        /// <summary>
        /// Security Accounts Manager initialization failed because of the following error: %1. Error Status: 0x%2. Please click OK to shutdown the system. You can use the recovery console to diagnose the system further.
        /// </summary>
        ERROR_DS_SAM_INIT_FAILURE_CONSOLE = 8562, // 0x00002172
        /// <summary>
        /// The version of the operating system is incompatible with the current AD DS forest functional level or AD LDS Configuration Set functional level. You must upgrade to a new version of the operating system before this server can become an AD DS Domain Controller or add an AD LDS Instance in this AD DS Forest or AD LDS Configuration Set.
        /// </summary>
        ERROR_DS_FOREST_VERSION_TOO_HIGH = 8563, // 0x00002173
        /// <summary>
        /// The version of the operating system installed is incompatible with the current domain functional level. You must upgrade to a new version of the operating system before this server can become a domain controller in this domain.
        /// </summary>
        ERROR_DS_DOMAIN_VERSION_TOO_HIGH = 8564, // 0x00002174
        /// <summary>
        /// The version of the operating system installed on this server no longer supports the current AD DS Forest functional level or AD LDS Configuration Set functional level. You must raise the AD DS Forest functional level or AD LDS Configuration Set functional level before this server can become an AD DS Domain Controller or an AD LDS Instance in this Forest or Configuration Set.
        /// </summary>
        ERROR_DS_FOREST_VERSION_TOO_LOW = 8565, // 0x00002175
        /// <summary>
        /// The version of the operating system installed on this server no longer supports the current domain functional level. You must raise the domain functional level before this server can become a domain controller in this domain.
        /// </summary>
        ERROR_DS_DOMAIN_VERSION_TOO_LOW = 8566, // 0x00002176
        /// <summary>
        /// The version of the operating system installed on this server is incompatible with the functional level of the domain or forest.
        /// </summary>
        ERROR_DS_INCOMPATIBLE_VERSION = 8567, // 0x00002177
        /// <summary>
        /// The functional level of the domain (or forest) cannot be raised to the requested value, because there exist one or more domain controllers in the domain (or forest) that are at a lower incompatible functional level.
        /// </summary>
        ERROR_DS_LOW_DSA_VERSION = 8568, // 0x00002178
        /// <summary>
        /// The forest functional level cannot be raised to the requested value since one or more domains are still in mixed domain mode. All domains in the forest must be in native mode, for you to raise the forest functional level.
        /// </summary>
        ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN = 8569, // 0x00002179
        /// <summary>The sort order requested is not supported.</summary>
        ERROR_DS_NOT_SUPPORTED_SORT_ORDER = 8570, // 0x0000217A
        /// <summary>
        /// The requested name already exists as a unique identifier.
        /// </summary>
        ERROR_DS_NAME_NOT_UNIQUE = 8571, // 0x0000217B
        /// <summary>
        /// The machine account was created pre-NT4. The account needs to be recreated.
        /// </summary>
        ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4 = 8572, // 0x0000217C
        /// <summary>The database is out of version store.</summary>
        ERROR_DS_OUT_OF_VERSION_STORE = 8573, // 0x0000217D
        /// <summary>
        /// Unable to continue operation because multiple conflicting controls were used.
        /// </summary>
        ERROR_DS_INCOMPATIBLE_CONTROLS_USED = 8574, // 0x0000217E
        /// <summary>
        /// Unable to find a valid security descriptor reference domain for this partition.
        /// </summary>
        ERROR_DS_NO_REF_DOMAIN = 8575, // 0x0000217F
        /// <summary>
        /// Schema update failed: The link identifier is reserved.
        /// </summary>
        ERROR_DS_RESERVED_LINK_ID = 8576, // 0x00002180
        /// <summary>
        /// Schema update failed: There are no link identifiers available.
        /// </summary>
        ERROR_DS_LINK_ID_NOT_AVAILABLE = 8577, // 0x00002181
        /// <summary>
        /// An account group cannot have a universal group as a member.
        /// </summary>
        ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER = 8578, // 0x00002182
        /// <summary>
        /// Rename or move operations on naming context heads or read-only objects are not allowed.
        /// </summary>
        ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE = 8579, // 0x00002183
        /// <summary>
        /// Move operations on objects in the schema naming context are not allowed.
        /// </summary>
        ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC = 8580, // 0x00002184
        /// <summary>
        /// A system flag has been set on the object and does not allow the object to be moved or renamed.
        /// </summary>
        ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG = 8581, // 0x00002185
        /// <summary>
        /// This object is not allowed to change its grandparent container. Moves are not forbidden on this object, but are restricted to sibling containers.
        /// </summary>
        ERROR_DS_MODIFYDN_WRONG_GRANDPARENT = 8582, // 0x00002186
        /// <summary>
        /// Unable to resolve completely, a referral to another forest is generated.
        /// </summary>
        ERROR_DS_NAME_ERROR_TRUST_REFERRAL = 8583, // 0x00002187
        /// <summary>
        /// The requested action is not supported on standard server.
        /// </summary>
        ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER = 8584, // 0x00002188
        /// <summary>
        /// Could not access a partition of the directory service located on a remote server. Make sure at least one server is running for the partition in question.
        /// </summary>
        ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD = 8585, // 0x00002189
        /// <summary>
        /// The directory cannot validate the proposed naming context (or partition) name because it does not hold a replica nor can it contact a replica of the naming context above the proposed naming context. Please ensure that the parent naming context is properly registered in DNS, and at least one replica of this naming context is reachable by the Domain Naming master.
        /// </summary>
        ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2 = 8586, // 0x0000218A
        /// <summary>The thread limit for this request was exceeded.</summary>
        ERROR_DS_THREAD_LIMIT_EXCEEDED = 8587, // 0x0000218B
        /// <summary>The Global catalog server is not in the closest site.</summary>
        ERROR_DS_NOT_CLOSEST = 8588, // 0x0000218C
        /// <summary>
        /// The DS cannot derive a service principal name (SPN) with which to mutually authenticate the target server because the corresponding server object in the local DS database has no serverReference attribute.
        /// </summary>
        ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF = 8589, // 0x0000218D
        /// <summary>
        /// The Directory Service failed to enter single user mode.
        /// </summary>
        ERROR_DS_SINGLE_USER_MODE_FAILED = 8590, // 0x0000218E
        /// <summary>
        /// The Directory Service cannot parse the script because of a syntax error.
        /// </summary>
        ERROR_DS_NTDSCRIPT_SYNTAX_ERROR = 8591, // 0x0000218F
        /// <summary>
        /// The Directory Service cannot process the script because of an error.
        /// </summary>
        ERROR_DS_NTDSCRIPT_PROCESS_ERROR = 8592, // 0x00002190
        /// <summary>
        /// The directory service cannot perform the requested operation because the servers involved are of different replication epochs (which is usually related to a domain rename that is in progress).
        /// </summary>
        ERROR_DS_DIFFERENT_REPL_EPOCHS = 8593, // 0x00002191
        /// <summary>
        /// The directory service binding must be renegotiated due to a change in the server extensions information.
        /// </summary>
        ERROR_DS_DRS_EXTENSIONS_CHANGED = 8594, // 0x00002192
        /// <summary>Operation not allowed on a disabled cross ref.</summary>
        ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR = 8595, // 0x00002193
        /// <summary>
        /// Schema update failed: No values for msDS-IntId are available.
        /// </summary>
        ERROR_DS_NO_MSDS_INTID = 8596, // 0x00002194
        /// <summary>
        /// Schema update failed: Duplicate msDS-INtId. Retry the operation.
        /// </summary>
        ERROR_DS_DUP_MSDS_INTID = 8597, // 0x00002195
        /// <summary>
        /// Schema deletion failed: attribute is used in rDNAttID.
        /// </summary>
        ERROR_DS_EXISTS_IN_RDNATTID = 8598, // 0x00002196
        /// <summary>
        /// The directory service failed to authorize the request.
        /// </summary>
        ERROR_DS_AUTHORIZATION_FAILED = 8599, // 0x00002197
        /// <summary>
        /// The Directory Service cannot process the script because it is invalid.
        /// </summary>
        ERROR_DS_INVALID_SCRIPT = 8600, // 0x00002198
        /// <summary>
        /// The remote create cross reference operation failed on the Domain Naming Master FSMO. The operation's error is in the extended data.
        /// </summary>
        ERROR_DS_REMOTE_CROSSREF_OP_FAILED = 8601, // 0x00002199
        /// <summary>
        /// A cross reference is in use locally with the same name.
        /// </summary>
        ERROR_DS_CROSS_REF_BUSY = 8602, // 0x0000219A
        /// <summary>
        /// The DS cannot derive a service principal name (SPN) with which to mutually authenticate the target server because the server's domain has been deleted from the forest.
        /// </summary>
        ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN = 8603, // 0x0000219B
        /// <summary>Writeable NCs prevent this DC from demoting.</summary>
        ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC = 8604, // 0x0000219C
        /// <summary>
        /// The requested object has a non-unique identifier and cannot be retrieved.
        /// </summary>
        ERROR_DS_DUPLICATE_ID_FOUND = 8605, // 0x0000219D
        /// <summary>
        /// Insufficient attributes were given to create an object. This object may not exist because it may have been deleted and already garbage collected.
        /// </summary>
        ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT = 8606, // 0x0000219E
        /// <summary>
        /// The group cannot be converted due to attribute restrictions on the requested group type.
        /// </summary>
        ERROR_DS_GROUP_CONVERSION_ERROR = 8607, // 0x0000219F
        /// <summary>
        /// Cross-domain move of non-empty basic application groups is not allowed.
        /// </summary>
        ERROR_DS_CANT_MOVE_APP_BASIC_GROUP = 8608, // 0x000021A0
        /// <summary>
        /// Cross-domain move of non-empty query based application groups is not allowed.
        /// </summary>
        ERROR_DS_CANT_MOVE_APP_QUERY_GROUP = 8609, // 0x000021A1
        /// <summary>
        /// The FSMO role ownership could not be verified because its directory partition has not replicated successfully with at least one replication partner.
        /// </summary>
        ERROR_DS_ROLE_NOT_VERIFIED = 8610, // 0x000021A2
        /// <summary>
        /// The target container for a redirection of a well known object container cannot already be a special container.
        /// </summary>
        ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL = 8611, // 0x000021A3
        /// <summary>
        /// The Directory Service cannot perform the requested operation because a domain rename operation is in progress.
        /// </summary>
        ERROR_DS_DOMAIN_RENAME_IN_PROGRESS = 8612, // 0x000021A4
        /// <summary>
        /// The directory service detected a child partition below the requested partition name. The partition hierarchy must be created in a top down method.
        /// </summary>
        ERROR_DS_EXISTING_AD_CHILD_NC = 8613, // 0x000021A5
        /// <summary>
        /// The directory service cannot replicate with this server because the time since the last replication with this server has exceeded the tombstone lifetime.
        /// </summary>
        ERROR_DS_REPL_LIFETIME_EXCEEDED = 8614, // 0x000021A6
        /// <summary>
        /// The requested operation is not allowed on an object under the system container.
        /// </summary>
        ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER = 8615, // 0x000021A7
        /// <summary>
        /// The LDAP servers network send queue has filled up because the client is not processing the results of its requests fast enough. No more requests will be processed until the client catches up. If the client does not catch up then it will be disconnected.
        /// </summary>
        ERROR_DS_LDAP_SEND_QUEUE_FULL = 8616, // 0x000021A8
        /// <summary>
        /// The scheduled replication did not take place because the system was too busy to execute the request within the schedule window. The replication queue is overloaded. Consider reducing the number of partners or decreasing the scheduled replication frequency.
        /// </summary>
        ERROR_DS_DRA_OUT_SCHEDULE_WINDOW = 8617, // 0x000021A9
        /// <summary>
        /// At this time, it cannot be determined if the branch replication policy is available on the hub domain controller. Please retry at a later time to account for replication latencies.
        /// </summary>
        ERROR_DS_POLICY_NOT_KNOWN = 8618, // 0x000021AA
        /// <summary>
        /// The site settings object for the specified site does not exist.
        /// </summary>
        ERROR_NO_SITE_SETTINGS_OBJECT = 8619, // 0x000021AB
        /// <summary>
        /// The local account store does not contain secret material for the specified account.
        /// </summary>
        ERROR_NO_SECRETS = 8620, // 0x000021AC
        /// <summary>
        /// Could not find a writable domain controller in the domain.
        /// </summary>
        ERROR_NO_WRITABLE_DC_FOUND = 8621, // 0x000021AD
        /// <summary>
        /// The server object for the domain controller does not exist.
        /// </summary>
        ERROR_DS_NO_SERVER_OBJECT = 8622, // 0x000021AE
        /// <summary>
        /// The NTDS Settings object for the domain controller does not exist.
        /// </summary>
        ERROR_DS_NO_NTDSA_OBJECT = 8623, // 0x000021AF
        /// <summary>
        /// The requested search operation is not supported for ASQ searches.
        /// </summary>
        ERROR_DS_NON_ASQ_SEARCH = 8624, // 0x000021B0
        /// <summary>
        /// A required audit event could not be generated for the operation.
        /// </summary>
        ERROR_DS_AUDIT_FAILURE = 8625, // 0x000021B1
        /// <summary>
        /// The search flags for the attribute are invalid. The subtree index bit is valid only on single valued attributes.
        /// </summary>
        ERROR_DS_INVALID_SEARCH_FLAG_SUBTREE = 8626, // 0x000021B2
        /// <summary>
        /// The search flags for the attribute are invalid. The tuple index bit is valid only on attributes of Unicode strings.
        /// </summary>
        ERROR_DS_INVALID_SEARCH_FLAG_TUPLE = 8627, // 0x000021B3
        /// <summary>
        /// The address books are nested too deeply. Failed to build the hierarchy table.
        /// </summary>
        ERROR_DS_HIERARCHY_TABLE_TOO_DEEP = 8628, // 0x000021B4
        /// <summary>The specified up-to-date-ness vector is corrupt.</summary>
        ERROR_DS_DRA_CORRUPT_UTD_VECTOR = 8629, // 0x000021B5
        /// <summary>The request to replicate secrets is denied.</summary>
        ERROR_DS_DRA_SECRETS_DENIED = 8630, // 0x000021B6
        /// <summary>
        /// Schema update failed: The MAPI identifier is reserved.
        /// </summary>
        ERROR_DS_RESERVED_MAPI_ID = 8631, // 0x000021B7
        /// <summary>
        /// Schema update failed: There are no MAPI identifiers available.
        /// </summary>
        ERROR_DS_MAPI_ID_NOT_AVAILABLE = 8632, // 0x000021B8
        /// <summary>
        /// The replication operation failed because the required attributes of the local krbtgt object are missing.
        /// </summary>
        ERROR_DS_DRA_MISSING_KRBTGT_SECRET = 8633, // 0x000021B9
        /// <summary>
        /// The domain name of the trusted domain already exists in the forest.
        /// </summary>
        ERROR_DS_DOMAIN_NAME_EXISTS_IN_FOREST = 8634, // 0x000021BA
        /// <summary>
        /// The flat name of the trusted domain already exists in the forest.
        /// </summary>
        ERROR_DS_FLAT_NAME_EXISTS_IN_FOREST = 8635, // 0x000021BB
        /// <summary>The User Principal Name (UPN) is invalid.</summary>
        ERROR_INVALID_USER_PRINCIPAL_NAME = 8636, // 0x000021BC
        /// <summary>OID mapped groups cannot have members.</summary>
        ERROR_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS = 8637, // 0x000021BD
        /// <summary>The specified OID cannot be found.</summary>
        ERROR_DS_OID_NOT_FOUND = 8638, // 0x000021BE
        /// <summary>
        /// The replication operation failed because the target object referred by a link value is recycled.
        /// </summary>
        ERROR_DS_DRA_RECYCLED_TARGET = 8639, // 0x000021BF
        /// <summary>
        /// The redirect operation failed because the target object is in a NC different from the domain NC of the current domain controller.
        /// </summary>
        ERROR_DS_DISALLOWED_NC_REDIRECT = 8640, // 0x000021C0
        /// <summary>
        /// The functional level of the AD LDS configuration set cannot be lowered to the requested value.
        /// </summary>
        ERROR_DS_HIGH_ADLDS_FFL = 8641, // 0x000021C1
        /// <summary>
        /// The functional level of the domain (or forest) cannot be lowered to the requested value.
        /// </summary>
        ERROR_DS_HIGH_DSA_VERSION = 8642, // 0x000021C2
        /// <summary>
        /// The functional level of the AD LDS configuration set cannot be raised to the requested value, because there exist one or more ADLDS instances that are at a lower incompatible functional level.
        /// </summary>
        ERROR_DS_LOW_ADLDS_FFL = 8643, // 0x000021C3
        /// <summary>
        /// The domain join cannot be completed because the SID of the domain you attempted to join was identical to the SID of this machine. This is a symptom of an improperly cloned operating system install.  You should run sysprep on this machine in order to generate a new machine SID. Please see http://go.microsoft.com/fwlink/p/?linkid=168895 for more information.
        /// </summary>
        ERROR_DOMAIN_SID_SAME_AS_LOCAL_WORKSTATION = 8644, // 0x000021C4
        /// <summary>
        /// The undelete operation failed because the Sam Account Name or Additional Sam Account Name of the object being undeleted conflicts with an existing live object.
        /// </summary>
        ERROR_DS_UNDELETE_SAM_VALIDATION_FAILED = 8645, // 0x000021C5
        /// <summary>
        /// The system is not authoritative for the specified account and therefore cannot complete the operation. Please retry the operation using the provider associated with this account. If this is an online provider please use the provider's online site.
        /// </summary>
        ERROR_INCORRECT_ACCOUNT_TYPE = 8646, // 0x000021C6
        /// <summary>DNS server unable to interpret format.</summary>
        DNS_ERROR_RCODE_FORMAT_ERROR = 9001, // 0x00002329
        /// <summary>DNS server failure.</summary>
        DNS_ERROR_RCODE_SERVER_FAILURE = 9002, // 0x0000232A
        /// <summary>DNS name does not exist.</summary>
        DNS_ERROR_RCODE_NAME_ERROR = 9003, // 0x0000232B
        /// <summary>DNS request not supported by name server.</summary>
        DNS_ERROR_RCODE_NOT_IMPLEMENTED = 9004, // 0x0000232C
        /// <summary>DNS operation refused.</summary>
        DNS_ERROR_RCODE_REFUSED = 9005, // 0x0000232D
        /// <summary>DNS name that ought not exist, does exist.</summary>
        DNS_ERROR_RCODE_YXDOMAIN = 9006, // 0x0000232E
        /// <summary>DNS RR set that ought not exist, does exist.</summary>
        DNS_ERROR_RCODE_YXRRSET = 9007, // 0x0000232F
        /// <summary>DNS RR set that ought to exist, does not exist.</summary>
        DNS_ERROR_RCODE_NXRRSET = 9008, // 0x00002330
        /// <summary>DNS server not authoritative for zone.</summary>
        DNS_ERROR_RCODE_NOTAUTH = 9009, // 0x00002331
        /// <summary>DNS name in update or prereq is not in zone.</summary>
        DNS_ERROR_RCODE_NOTZONE = 9010, // 0x00002332
        /// <summary>DNS signature failed to verify.</summary>
        DNS_ERROR_RCODE_BADSIG = 9016, // 0x00002338
        /// <summary>DNS bad key.</summary>
        DNS_ERROR_RCODE_BADKEY = 9017, // 0x00002339
        /// <summary>DNS signature validity expired.</summary>
        DNS_ERROR_RCODE_BADTIME = 9018, // 0x0000233A
        /// <summary>
        /// Only the DNS server acting as the key master for the zone may perform this operation.
        /// </summary>
        DNS_ERROR_KEYMASTER_REQUIRED = 9101, // 0x0000238D
        /// <summary>
        /// This operation is not allowed on a zone that is signed or has signing keys.
        /// </summary>
        DNS_ERROR_NOT_ALLOWED_ON_SIGNED_ZONE = 9102, // 0x0000238E
        /// <summary>
        /// NSEC3 is not compatible with the RSA-SHA-1 algorithm. Choose a different algorithm or use NSEC. This value was also named DNS_ERROR_INVALID_NSEC3_PARAMETERS
        /// </summary>
        DNS_ERROR_NSEC3_INCOMPATIBLE_WITH_RSA_SHA1 = 9103, // 0x0000238F
        /// <summary>
        /// The zone does not have enough signing keys. There must be at least one key signing key (KSK) and at least one zone signing key (ZSK).
        /// </summary>
        DNS_ERROR_NOT_ENOUGH_SIGNING_KEY_DESCRIPTORS = 9104, // 0x00002390
        /// <summary>The specified algorithm is not supported.</summary>
        DNS_ERROR_UNSUPPORTED_ALGORITHM = 9105, // 0x00002391
        /// <summary>The specified key size is not supported.</summary>
        DNS_ERROR_INVALID_KEY_SIZE = 9106, // 0x00002392
        /// <summary>
        /// One or more of the signing keys for a zone are not accessible to the DNS server. Zone signing will not be operational until this error is resolved.
        /// </summary>
        DNS_ERROR_SIGNING_KEY_NOT_ACCESSIBLE = 9107, // 0x00002393
        /// <summary>
        /// The specified key storage provider does not support DPAPI++ data protection. Zone signing will not be operational until this error is resolved.
        /// </summary>
        DNS_ERROR_KSP_DOES_NOT_SUPPORT_PROTECTION = 9108, // 0x00002394
        /// <summary>
        /// An unexpected DPAPI++ error was encountered. Zone signing will not be operational until this error is resolved.
        /// </summary>
        DNS_ERROR_UNEXPECTED_DATA_PROTECTION_ERROR = 9109, // 0x00002395
        /// <summary>
        /// An unexpected crypto error was encountered. Zone signing may not be operational until this error is resolved.
        /// </summary>
        DNS_ERROR_UNEXPECTED_CNG_ERROR = 9110, // 0x00002396
        /// <summary>
        /// The DNS server encountered a signing key with an unknown version. Zone signing will not be operational until this error is resolved.
        /// </summary>
        DNS_ERROR_UNKNOWN_SIGNING_PARAMETER_VERSION = 9111, // 0x00002397
        /// <summary>
        /// The specified key service provider cannot be opened by the DNS server.
        /// </summary>
        DNS_ERROR_KSP_NOT_ACCESSIBLE = 9112, // 0x00002398
        /// <summary>
        /// The DNS server cannot accept any more signing keys with the specified algorithm and KSK flag value for this zone.
        /// </summary>
        DNS_ERROR_TOO_MANY_SKDS = 9113, // 0x00002399
        /// <summary>The specified rollover period is invalid.</summary>
        DNS_ERROR_INVALID_ROLLOVER_PERIOD = 9114, // 0x0000239A
        /// <summary>The specified initial rollover offset is invalid.</summary>
        DNS_ERROR_INVALID_INITIAL_ROLLOVER_OFFSET = 9115, // 0x0000239B
        /// <summary>
        /// The specified signing key is already in process of rolling over keys.
        /// </summary>
        DNS_ERROR_ROLLOVER_IN_PROGRESS = 9116, // 0x0000239C
        /// <summary>
        /// The specified signing key does not have a standby key to revoke.
        /// </summary>
        DNS_ERROR_STANDBY_KEY_NOT_PRESENT = 9117, // 0x0000239D
        /// <summary>
        /// This operation is not allowed on a zone signing key (ZSK).
        /// </summary>
        DNS_ERROR_NOT_ALLOWED_ON_ZSK = 9118, // 0x0000239E
        /// <summary>
        /// This operation is not allowed on an active signing key.
        /// </summary>
        DNS_ERROR_NOT_ALLOWED_ON_ACTIVE_SKD = 9119, // 0x0000239F
        /// <summary>
        /// The specified signing key is already queued for rollover.
        /// </summary>
        DNS_ERROR_ROLLOVER_ALREADY_QUEUED = 9120, // 0x000023A0
        /// <summary>This operation is not allowed on an unsigned zone.</summary>
        DNS_ERROR_NOT_ALLOWED_ON_UNSIGNED_ZONE = 9121, // 0x000023A1
        /// <summary>
        /// This operation could not be completed because the DNS server listed as the current key master for this zone is down or misconfigured. Resolve the problem on the current key master for this zone or use another DNS server to seize the key master role.
        /// </summary>
        DNS_ERROR_BAD_KEYMASTER = 9122, // 0x000023A2
        /// <summary>The specified signature validity period is invalid.</summary>
        DNS_ERROR_INVALID_SIGNATURE_VALIDITY_PERIOD = 9123, // 0x000023A3
        /// <summary>
        /// The specified NSEC3 iteration count is higher than allowed by the minimum key length used in the zone.
        /// </summary>
        DNS_ERROR_INVALID_NSEC3_ITERATION_COUNT = 9124, // 0x000023A4
        /// <summary>
        /// This operation could not be completed because the DNS server has been configured with DNSSEC features disabled. Enable DNSSEC on the DNS server.
        /// </summary>
        DNS_ERROR_DNSSEC_IS_DISABLED = 9125, // 0x000023A5
        /// <summary>
        /// This operation could not be completed because the XML stream received is empty or syntactically invalid.
        /// </summary>
        DNS_ERROR_INVALID_XML = 9126, // 0x000023A6
        /// <summary>
        /// This operation completed, but no trust anchors were added because all of the trust anchors received were either invalid, unsupported, expired, or would not become valid in less than 30 days.
        /// </summary>
        DNS_ERROR_NO_VALID_TRUST_ANCHORS = 9127, // 0x000023A7
        /// <summary>
        /// The specified signing key is not waiting for parental DS update.
        /// </summary>
        DNS_ERROR_ROLLOVER_NOT_POKEABLE = 9128, // 0x000023A8
        /// <summary>
        /// Hash collision detected during NSEC3 signing. Specify a different user-provided salt, or use a randomly generated salt, and attempt to sign the zone again.
        /// </summary>
        DNS_ERROR_NSEC3_NAME_COLLISION = 9129, // 0x000023A9
        /// <summary>
        /// NSEC is not compatible with the NSEC3-RSA-SHA-1 algorithm. Choose a different algorithm or use NSEC3.
        /// </summary>
        DNS_ERROR_NSEC_INCOMPATIBLE_WITH_NSEC3_RSA_SHA1 = 9130, // 0x000023AA
        /// <summary>No records found for given DNS query.</summary>
        DNS_INFO_NO_RECORDS = 9501, // 0x0000251D
        /// <summary>Bad DNS packet.</summary>
        DNS_ERROR_BAD_PACKET = 9502, // 0x0000251E
        /// <summary>No DNS packet.</summary>
        DNS_ERROR_NO_PACKET = 9503, // 0x0000251F
        /// <summary>DNS error, check rcode.</summary>
        DNS_ERROR_RCODE = 9504, // 0x00002520
        /// <summary>Unsecured DNS packet.</summary>
        DNS_ERROR_UNSECURE_PACKET = 9505, // 0x00002521
        /// <summary>DNS query request is pending.</summary>
        DNS_REQUEST_PENDING = 9506, // 0x00002522
        /// <summary>Invalid DNS type.</summary>
        DNS_ERROR_INVALID_TYPE = 9551, // 0x0000254F
        /// <summary>Invalid IP address.</summary>
        DNS_ERROR_INVALID_IP_ADDRESS = 9552, // 0x00002550
        /// <summary>Invalid property.</summary>
        DNS_ERROR_INVALID_PROPERTY = 9553, // 0x00002551
        /// <summary>Try DNS operation again later.</summary>
        DNS_ERROR_TRY_AGAIN_LATER = 9554, // 0x00002552
        /// <summary>Record for given name and type is not unique.</summary>
        DNS_ERROR_NOT_UNIQUE = 9555, // 0x00002553
        /// <summary>DNS name does not comply with RFC specifications.</summary>
        DNS_ERROR_NON_RFC_NAME = 9556, // 0x00002554
        /// <summary>DNS name is a fully-qualified DNS name.</summary>
        DNS_STATUS_FQDN = 9557, // 0x00002555
        /// <summary>DNS name is dotted (multi-label).</summary>
        DNS_STATUS_DOTTED_NAME = 9558, // 0x00002556
        /// <summary>DNS name is a single-part name.</summary>
        DNS_STATUS_SINGLE_PART_NAME = 9559, // 0x00002557
        /// <summary>DNS name contains an invalid character.</summary>
        DNS_ERROR_INVALID_NAME_CHAR = 9560, // 0x00002558
        /// <summary>DNS name is entirely numeric.</summary>
        DNS_ERROR_NUMERIC_NAME = 9561, // 0x00002559
        /// <summary>
        /// The operation requested is not permitted on a DNS root server.
        /// </summary>
        DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER = 9562, // 0x0000255A
        /// <summary>
        /// The record could not be created because this part of the DNS namespace has been delegated to another server.
        /// </summary>
        DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION = 9563, // 0x0000255B
        /// <summary>The DNS server could not find a set of root hints.</summary>
        DNS_ERROR_CANNOT_FIND_ROOT_HINTS = 9564, // 0x0000255C
        /// <summary>
        /// The DNS server found root hints but they were not consistent across all adapters.
        /// </summary>
        DNS_ERROR_INCONSISTENT_ROOT_HINTS = 9565, // 0x0000255D
        /// <summary>The specified value is too small for this parameter.</summary>
        DNS_ERROR_DWORD_VALUE_TOO_SMALL = 9566, // 0x0000255E
        /// <summary>The specified value is too large for this parameter.</summary>
        DNS_ERROR_DWORD_VALUE_TOO_LARGE = 9567, // 0x0000255F
        /// <summary>
        /// This operation is not allowed while the DNS server is loading zones in the background. Please try again later.
        /// </summary>
        DNS_ERROR_BACKGROUND_LOADING = 9568, // 0x00002560
        /// <summary>
        /// The operation requested is not permitted on against a DNS server running on a read-only DC.
        /// </summary>
        DNS_ERROR_NOT_ALLOWED_ON_RODC = 9569, // 0x00002561
        /// <summary>
        /// No data is allowed to exist underneath a DNAME record.
        /// </summary>
        DNS_ERROR_NOT_ALLOWED_UNDER_DNAME = 9570, // 0x00002562
        /// <summary>This operation requires credentials delegation.</summary>
        DNS_ERROR_DELEGATION_REQUIRED = 9571, // 0x00002563
        /// <summary>
        /// Name resolution policy table has been corrupted. DNS resolution will fail until it is fixed. Contact your network administrator.
        /// </summary>
        DNS_ERROR_INVALID_POLICY_TABLE = 9572, // 0x00002564
        /// <summary>DNS zone does not exist.</summary>
        DNS_ERROR_ZONE_DOES_NOT_EXIST = 9601, // 0x00002581
        /// <summary>DNS zone information not available.</summary>
        DNS_ERROR_NO_ZONE_INFO = 9602, // 0x00002582
        /// <summary>Invalid operation for DNS zone.</summary>
        DNS_ERROR_INVALID_ZONE_OPERATION = 9603, // 0x00002583
        /// <summary>Invalid DNS zone configuration.</summary>
        DNS_ERROR_ZONE_CONFIGURATION_ERROR = 9604, // 0x00002584
        /// <summary>DNS zone has no start of authority (SOA) record.</summary>
        DNS_ERROR_ZONE_HAS_NO_SOA_RECORD = 9605, // 0x00002585
        /// <summary>DNS zone has no Name Server (NS) record.</summary>
        DNS_ERROR_ZONE_HAS_NO_NS_RECORDS = 9606, // 0x00002586
        /// <summary>DNS zone is locked.</summary>
        DNS_ERROR_ZONE_LOCKED = 9607, // 0x00002587
        /// <summary>DNS zone creation failed.</summary>
        DNS_ERROR_ZONE_CREATION_FAILED = 9608, // 0x00002588
        /// <summary>DNS zone already exists.</summary>
        DNS_ERROR_ZONE_ALREADY_EXISTS = 9609, // 0x00002589
        /// <summary>DNS automatic zone already exists.</summary>
        DNS_ERROR_AUTOZONE_ALREADY_EXISTS = 9610, // 0x0000258A
        /// <summary>Invalid DNS zone type.</summary>
        DNS_ERROR_INVALID_ZONE_TYPE = 9611, // 0x0000258B
        /// <summary>Secondary DNS zone requires master IP address.</summary>
        DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP = 9612, // 0x0000258C
        /// <summary>DNS zone not secondary.</summary>
        DNS_ERROR_ZONE_NOT_SECONDARY = 9613, // 0x0000258D
        /// <summary>Need secondary IP address.</summary>
        DNS_ERROR_NEED_SECONDARY_ADDRESSES = 9614, // 0x0000258E
        /// <summary>WINS initialization failed.</summary>
        DNS_ERROR_WINS_INIT_FAILED = 9615, // 0x0000258F
        /// <summary>Need WINS servers.</summary>
        DNS_ERROR_NEED_WINS_SERVERS = 9616, // 0x00002590
        /// <summary>NBTSTAT initialization call failed.</summary>
        DNS_ERROR_NBSTAT_INIT_FAILED = 9617, // 0x00002591
        /// <summary>Invalid delete of start of authority (SOA).</summary>
        DNS_ERROR_SOA_DELETE_INVALID = 9618, // 0x00002592
        /// <summary>
        /// A conditional forwarding zone already exists for that name.
        /// </summary>
        DNS_ERROR_FORWARDER_ALREADY_EXISTS = 9619, // 0x00002593
        /// <summary>
        /// This zone must be configured with one or more master DNS server IP addresses.
        /// </summary>
        DNS_ERROR_ZONE_REQUIRES_MASTER_IP = 9620, // 0x00002594
        /// <summary>
        /// The operation cannot be performed because this zone is shut down.
        /// </summary>
        DNS_ERROR_ZONE_IS_SHUTDOWN = 9621, // 0x00002595
        /// <summary>
        /// This operation cannot be performed because the zone is currently being signed. Please try again later.
        /// </summary>
        DNS_ERROR_ZONE_LOCKED_FOR_SIGNING = 9622, // 0x00002596
        /// <summary>Primary DNS zone requires datafile.</summary>
        DNS_ERROR_PRIMARY_REQUIRES_DATAFILE = 9651, // 0x000025B3
        /// <summary>Invalid datafile name for DNS zone.</summary>
        DNS_ERROR_INVALID_DATAFILE_NAME = 9652, // 0x000025B4
        /// <summary>Failed to open datafile for DNS zone.</summary>
        DNS_ERROR_DATAFILE_OPEN_FAILURE = 9653, // 0x000025B5
        /// <summary>Failed to write datafile for DNS zone.</summary>
        DNS_ERROR_FILE_WRITEBACK_FAILED = 9654, // 0x000025B6
        /// <summary>Failure while reading datafile for DNS zone.</summary>
        DNS_ERROR_DATAFILE_PARSING = 9655, // 0x000025B7
        /// <summary>DNS record does not exist.</summary>
        DNS_ERROR_RECORD_DOES_NOT_EXIST = 9701, // 0x000025E5
        /// <summary>DNS record format error.</summary>
        DNS_ERROR_RECORD_FORMAT = 9702, // 0x000025E6
        /// <summary>Node creation failure in DNS.</summary>
        DNS_ERROR_NODE_CREATION_FAILED = 9703, // 0x000025E7
        /// <summary>Unknown DNS record type.</summary>
        DNS_ERROR_UNKNOWN_RECORD_TYPE = 9704, // 0x000025E8
        /// <summary>DNS record timed out.</summary>
        DNS_ERROR_RECORD_TIMED_OUT = 9705, // 0x000025E9
        /// <summary>Name not in DNS zone.</summary>
        DNS_ERROR_NAME_NOT_IN_ZONE = 9706, // 0x000025EA
        /// <summary>CNAME loop detected.</summary>
        DNS_ERROR_CNAME_LOOP = 9707, // 0x000025EB
        /// <summary>Node is a CNAME DNS record.</summary>
        DNS_ERROR_NODE_IS_CNAME = 9708, // 0x000025EC
        /// <summary>A CNAME record already exists for given name.</summary>
        DNS_ERROR_CNAME_COLLISION = 9709, // 0x000025ED
        /// <summary>Record only at DNS zone root.</summary>
        DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT = 9710, // 0x000025EE
        /// <summary>DNS record already exists.</summary>
        DNS_ERROR_RECORD_ALREADY_EXISTS = 9711, // 0x000025EF
        /// <summary>Secondary DNS zone data error.</summary>
        DNS_ERROR_SECONDARY_DATA = 9712, // 0x000025F0
        /// <summary>Could not create DNS cache data.</summary>
        DNS_ERROR_NO_CREATE_CACHE_DATA = 9713, // 0x000025F1
        /// <summary>DNS name does not exist.</summary>
        DNS_ERROR_NAME_DOES_NOT_EXIST = 9714, // 0x000025F2
        /// <summary>Could not create pointer (PTR) record.</summary>
        DNS_WARNING_PTR_CREATE_FAILED = 9715, // 0x000025F3
        /// <summary>DNS domain was undeleted.</summary>
        DNS_WARNING_DOMAIN_UNDELETED = 9716, // 0x000025F4
        /// <summary>The directory service is unavailable.</summary>
        DNS_ERROR_DS_UNAVAILABLE = 9717, // 0x000025F5
        /// <summary>DNS zone already exists in the directory service.</summary>
        DNS_ERROR_DS_ZONE_ALREADY_EXISTS = 9718, // 0x000025F6
        /// <summary>
        /// DNS server not creating or reading the boot file for the directory service integrated DNS zone.
        /// </summary>
        DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE = 9719, // 0x000025F7
        /// <summary>Node is a DNAME DNS record.</summary>
        DNS_ERROR_NODE_IS_DNAME = 9720, // 0x000025F8
        /// <summary>A DNAME record already exists for given name.</summary>
        DNS_ERROR_DNAME_COLLISION = 9721, // 0x000025F9
        /// <summary>
        /// An alias loop has been detected with either CNAME or DNAME records.
        /// </summary>
        DNS_ERROR_ALIAS_LOOP = 9722, // 0x000025FA
        /// <summary>DNS AXFR (zone transfer) complete.</summary>
        DNS_INFO_AXFR_COMPLETE = 9751, // 0x00002617
        /// <summary>DNS zone transfer failed.</summary>
        DNS_ERROR_AXFR = 9752, // 0x00002618
        /// <summary>Added local WINS server.</summary>
        DNS_INFO_ADDED_LOCAL_WINS = 9753, // 0x00002619
        /// <summary>Secure update call needs to continue update request.</summary>
        DNS_STATUS_CONTINUE_NEEDED = 9801, // 0x00002649
        /// <summary>TCP/IP network protocol not installed.</summary>
        DNS_ERROR_NO_TCPIP = 9851, // 0x0000267B
        /// <summary>No DNS servers configured for local system.</summary>
        DNS_ERROR_NO_DNS_SERVERS = 9852, // 0x0000267C
        /// <summary>The specified directory partition does not exist.</summary>
        DNS_ERROR_DP_DOES_NOT_EXIST = 9901, // 0x000026AD
        /// <summary>The specified directory partition already exists.</summary>
        DNS_ERROR_DP_ALREADY_EXISTS = 9902, // 0x000026AE
        /// <summary>
        /// This DNS server is not enlisted in the specified directory partition.
        /// </summary>
        DNS_ERROR_DP_NOT_ENLISTED = 9903, // 0x000026AF
        /// <summary>
        /// This DNS server is already enlisted in the specified directory partition.
        /// </summary>
        DNS_ERROR_DP_ALREADY_ENLISTED = 9904, // 0x000026B0
        /// <summary>
        /// The directory partition is not available at this time. Please wait a few minutes and try again.
        /// </summary>
        DNS_ERROR_DP_NOT_AVAILABLE = 9905, // 0x000026B1
        /// <summary>
        /// The operation failed because the domain naming master FSMO role could not be reached. The domain controller holding the domain naming master FSMO role is down or unable to service the request or is not running Windows Server 2003 or later.
        /// </summary>
        DNS_ERROR_DP_FSMO_ERROR = 9906, // 0x000026B2
        /// <summary>
        /// A blocking operation was interrupted by a call to WSACancelBlockingCall.
        /// </summary>
        WSAEINTR = 10004, // 0x00002714
        /// <summary>The file handle supplied is not valid.</summary>
        WSAEBADF = 10009, // 0x00002719
        /// <summary>
        /// An attempt was made to access a socket in a way forbidden by its access permissions.
        /// </summary>
        WSAEACCES = 10013, // 0x0000271D
        /// <summary>
        /// The system detected an invalid pointer address in attempting to use a pointer argument in a call.
        /// </summary>
        WSAEFAULT = 10014, // 0x0000271E
        /// <summary>An invalid argument was supplied.</summary>
        WSAEINVAL = 10022, // 0x00002726
        /// <summary>Too many open sockets.</summary>
        WSAEMFILE = 10024, // 0x00002728
        /// <summary>
        /// A non-blocking socket operation could not be completed immediately.
        /// </summary>
        WSAEWOULDBLOCK = 10035, // 0x00002733
        /// <summary>A blocking operation is currently executing.</summary>
        WSAEINPROGRESS = 10036, // 0x00002734
        /// <summary>
        /// An operation was attempted on a non-blocking socket that already had an operation in progress.
        /// </summary>
        WSAEALREADY = 10037, // 0x00002735
        /// <summary>
        /// An operation was attempted on something that is not a socket.
        /// </summary>
        WSAENOTSOCK = 10038, // 0x00002736
        /// <summary>
        /// A required address was omitted from an operation on a socket.
        /// </summary>
        WSAEDESTADDRREQ = 10039, // 0x00002737
        /// <summary>
        /// A message sent on a datagram socket was larger than the internal message buffer or some other network limit, or the buffer used to receive a datagram into was smaller than the datagram itself.
        /// </summary>
        WSAEMSGSIZE = 10040, // 0x00002738
        /// <summary>
        /// A protocol was specified in the socket function call that does not support the semantics of the socket type requested.
        /// </summary>
        WSAEPROTOTYPE = 10041, // 0x00002739
        /// <summary>
        /// An unknown, invalid, or unsupported option or level was specified in a getsockopt or setsockopt call.
        /// </summary>
        WSAENOPROTOOPT = 10042, // 0x0000273A
        /// <summary>
        /// The requested protocol has not been configured into the system, or no implementation for it exists.
        /// </summary>
        WSAEPROTONOSUPPORT = 10043, // 0x0000273B
        /// <summary>
        /// The support for the specified socket type does not exist in this address family.
        /// </summary>
        WSAESOCKTNOSUPPORT = 10044, // 0x0000273C
        /// <summary>
        /// The attempted operation is not supported for the type of object referenced.
        /// </summary>
        WSAEOPNOTSUPP = 10045, // 0x0000273D
        /// <summary>
        /// The protocol family has not been configured into the system or no implementation for it exists.
        /// </summary>
        WSAEPFNOSUPPORT = 10046, // 0x0000273E
        /// <summary>
        /// An address incompatible with the requested protocol was used.
        /// </summary>
        WSAEAFNOSUPPORT = 10047, // 0x0000273F
        /// <summary>
        /// Only one usage of each socket address (protocol/network address/port) is normally permitted.
        /// </summary>
        WSAEADDRINUSE = 10048, // 0x00002740
        /// <summary>The requested address is not valid in its context.</summary>
        WSAEADDRNOTAVAIL = 10049, // 0x00002741
        /// <summary>A socket operation encountered a dead network.</summary>
        WSAENETDOWN = 10050, // 0x00002742
        /// <summary>
        /// A socket operation was attempted to an unreachable network.
        /// </summary>
        WSAENETUNREACH = 10051, // 0x00002743
        /// <summary>
        /// The connection has been broken due to keep-alive activity detecting a failure while the operation was in progress.
        /// </summary>
        WSAENETRESET = 10052, // 0x00002744
        /// <summary>
        /// An established connection was aborted by the software in your host machine.
        /// </summary>
        WSAECONNABORTED = 10053, // 0x00002745
        /// <summary>
        /// An existing connection was forcibly closed by the remote host.
        /// </summary>
        WSAECONNRESET = 10054, // 0x00002746
        /// <summary>
        /// An operation on a socket could not be performed because the system lacked sufficient buffer space or because a queue was full.
        /// </summary>
        WSAENOBUFS = 10055, // 0x00002747
        /// <summary>
        /// A connect request was made on an already connected socket.
        /// </summary>
        WSAEISCONN = 10056, // 0x00002748
        /// <summary>
        /// A request to send or receive data was disallowed because the socket is not connected and (when sending on a datagram socket using a sendto call) no address was supplied.
        /// </summary>
        WSAENOTCONN = 10057, // 0x00002749
        /// <summary>
        /// A request to send or receive data was disallowed because the socket had already been shut down in that direction with a previous shutdown call.
        /// </summary>
        WSAESHUTDOWN = 10058, // 0x0000274A
        /// <summary>Too many references to some kernel object.</summary>
        WSAETOOMANYREFS = 10059, // 0x0000274B
        /// <summary>
        /// A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond.
        /// </summary>
        WSAETIMEDOUT = 10060, // 0x0000274C
        /// <summary>
        /// No connection could be made because the target machine actively refused it.
        /// </summary>
        WSAECONNREFUSED = 10061, // 0x0000274D
        /// <summary>Cannot translate name.</summary>
        WSAELOOP = 10062, // 0x0000274E
        /// <summary>Name component or name was too long.</summary>
        WSAENAMETOOLONG = 10063, // 0x0000274F
        /// <summary>
        /// A socket operation failed because the destination host was down.
        /// </summary>
        WSAEHOSTDOWN = 10064, // 0x00002750
        /// <summary>
        /// A socket operation was attempted to an unreachable host.
        /// </summary>
        WSAEHOSTUNREACH = 10065, // 0x00002751
        /// <summary>Cannot remove a directory that is not empty.</summary>
        WSAENOTEMPTY = 10066, // 0x00002752
        /// <summary>
        /// A Windows Sockets implementation may have a limit on the number of applications that may use it simultaneously.
        /// </summary>
        WSAEPROCLIM = 10067, // 0x00002753
        /// <summary>Ran out of quota.</summary>
        WSAEUSERS = 10068, // 0x00002754
        /// <summary>Ran out of disk quota.</summary>
        WSAEDQUOT = 10069, // 0x00002755
        /// <summary>File handle reference is no longer available.</summary>
        WSAESTALE = 10070, // 0x00002756
        /// <summary>Item is not available locally.</summary>
        WSAEREMOTE = 10071, // 0x00002757
        /// <summary>
        /// WSAStartup cannot function at this time because the underlying system it uses to provide network services is currently unavailable.
        /// </summary>
        WSASYSNOTREADY = 10091, // 0x0000276B
        /// <summary>
        /// The Windows Sockets version requested is not supported.
        /// </summary>
        WSAVERNOTSUPPORTED = 10092, // 0x0000276C
        /// <summary>
        /// Either the application has not called WSAStartup, or WSAStartup failed.
        /// </summary>
        WSANOTINITIALISED = 10093, // 0x0000276D
        /// <summary>
        /// Returned by WSARecv or WSARecvFrom to indicate the remote party has initiated a graceful shutdown sequence.
        /// </summary>
        WSAEDISCON = 10101, // 0x00002775
        /// <summary>
        /// No more results can be returned by WSALookupServiceNext.
        /// </summary>
        WSAENOMORE = 10102, // 0x00002776
        /// <summary>
        /// A call to WSALookupServiceEnd was made while this call was still processing. The call has been canceled.
        /// </summary>
        WSAECANCELLED = 10103, // 0x00002777
        /// <summary>The procedure call table is invalid.</summary>
        WSAEINVALIDPROCTABLE = 10104, // 0x00002778
        /// <summary>The requested service provider is invalid.</summary>
        WSAEINVALIDPROVIDER = 10105, // 0x00002779
        /// <summary>
        /// The requested service provider could not be loaded or initialized.
        /// </summary>
        WSAEPROVIDERFAILEDINIT = 10106, // 0x0000277A
        /// <summary>A system call has failed.</summary>
        WSASYSCALLFAILURE = 10107, // 0x0000277B
        /// <summary>
        /// No such service is known. The service cannot be found in the specified name space.
        /// </summary>
        WSASERVICE_NOT_FOUND = 10108, // 0x0000277C
        /// <summary>The specified class was not found.</summary>
        WSATYPE_NOT_FOUND = 10109, // 0x0000277D
        /// <summary>
        /// No more results can be returned by WSALookupServiceNext.
        /// </summary>
        WSA_E_NO_MORE = 10110, // 0x0000277E
        /// <summary>
        /// A call to WSALookupServiceEnd was made while this call was still processing. The call has been canceled.
        /// </summary>
        WSA_E_CANCELLED = 10111, // 0x0000277F
        /// <summary>
        /// A database query failed because it was actively refused.
        /// </summary>
        WSAEREFUSED = 10112, // 0x00002780
        /// <summary>No such host is known.</summary>
        WSAHOST_NOT_FOUND = 11001, // 0x00002AF9
        /// <summary>
        /// This is usually a temporary error during hostname resolution and means that the local server did not receive a response from an authoritative server.
        /// </summary>
        WSATRY_AGAIN = 11002, // 0x00002AFA
        /// <summary>
        /// A non-recoverable error occurred during a database lookup.
        /// </summary>
        WSANO_RECOVERY = 11003, // 0x00002AFB
        /// <summary>
        /// The requested name is valid, but no data of the requested type was found.
        /// </summary>
        WSANO_DATA = 11004, // 0x00002AFC
        /// <summary>At least one reserve has arrived.</summary>
        WSA_QOS_RECEIVERS = 11005, // 0x00002AFD
        /// <summary>At least one path has arrived.</summary>
        WSA_QOS_SENDERS = 11006, // 0x00002AFE
        /// <summary>There are no senders.</summary>
        WSA_QOS_NO_SENDERS = 11007, // 0x00002AFF
        /// <summary>There are no receivers.</summary>
        WSA_QOS_NO_RECEIVERS = 11008, // 0x00002B00
        /// <summary>Reserve has been confirmed.</summary>
        WSA_QOS_REQUEST_CONFIRMED = 11009, // 0x00002B01
        /// <summary>Error due to lack of resources.</summary>
        WSA_QOS_ADMISSION_FAILURE = 11010, // 0x00002B02
        /// <summary>
        /// Rejected for administrative reasons - bad credentials.
        /// </summary>
        WSA_QOS_POLICY_FAILURE = 11011, // 0x00002B03
        /// <summary>Unknown or conflicting style.</summary>
        WSA_QOS_BAD_STYLE = 11012, // 0x00002B04
        /// <summary>
        /// Problem with some part of the filterspec or providerspecific buffer in general.
        /// </summary>
        WSA_QOS_BAD_OBJECT = 11013, // 0x00002B05
        /// <summary>Problem with some part of the flowspec.</summary>
        WSA_QOS_TRAFFIC_CTRL_ERROR = 11014, // 0x00002B06
        /// <summary>General QOS error.</summary>
        WSA_QOS_GENERIC_ERROR = 11015, // 0x00002B07
        /// <summary>
        /// An invalid or unrecognized service type was found in the flowspec.
        /// </summary>
        WSA_QOS_ESERVICETYPE = 11016, // 0x00002B08
        /// <summary>
        /// An invalid or inconsistent flowspec was found in the QOS structure.
        /// </summary>
        WSA_QOS_EFLOWSPEC = 11017, // 0x00002B09
        /// <summary>Invalid QOS provider-specific buffer.</summary>
        WSA_QOS_EPROVSPECBUF = 11018, // 0x00002B0A
        /// <summary>An invalid QOS filter style was used.</summary>
        WSA_QOS_EFILTERSTYLE = 11019, // 0x00002B0B
        /// <summary>An invalid QOS filter type was used.</summary>
        WSA_QOS_EFILTERTYPE = 11020, // 0x00002B0C
        /// <summary>
        /// An incorrect number of QOS FILTERSPECs were specified in the FLOWDESCRIPTOR.
        /// </summary>
        WSA_QOS_EFILTERCOUNT = 11021, // 0x00002B0D
        /// <summary>
        /// An object with an invalid ObjectLength field was specified in the QOS provider-specific buffer.
        /// </summary>
        WSA_QOS_EOBJLENGTH = 11022, // 0x00002B0E
        /// <summary>
        /// An incorrect number of flow descriptors was specified in the QOS structure.
        /// </summary>
        WSA_QOS_EFLOWCOUNT = 11023, // 0x00002B0F
        /// <summary>
        /// An unrecognized object was found in the QOS provider-specific buffer.
        /// </summary>
        WSA_QOS_EUNKOWNPSOBJ = 11024, // 0x00002B10
        /// <summary>
        /// An invalid policy object was found in the QOS provider-specific buffer.
        /// </summary>
        WSA_QOS_EPOLICYOBJ = 11025, // 0x00002B11
        /// <summary>
        /// An invalid QOS flow descriptor was found in the flow descriptor list.
        /// </summary>
        WSA_QOS_EFLOWDESC = 11026, // 0x00002B12
        /// <summary>
        /// An invalid or inconsistent flowspec was found in the QOS provider specific buffer.
        /// </summary>
        WSA_QOS_EPSFLOWSPEC = 11027, // 0x00002B13
        /// <summary>
        /// An invalid FILTERSPEC was found in the QOS provider-specific buffer.
        /// </summary>
        WSA_QOS_EPSFILTERSPEC = 11028, // 0x00002B14
        /// <summary>
        /// An invalid shape discard mode object was found in the QOS provider specific buffer.
        /// </summary>
        WSA_QOS_ESDMODEOBJ = 11029, // 0x00002B15
        /// <summary>
        /// An invalid shaping rate object was found in the QOS provider-specific buffer.
        /// </summary>
        WSA_QOS_ESHAPERATEOBJ = 11030, // 0x00002B16
        /// <summary>
        /// A reserved policy element was found in the QOS provider-specific buffer.
        /// </summary>
        WSA_QOS_RESERVED_PETYPE = 11031, // 0x00002B17
        /// <summary>No such host is known securely.</summary>
        WSA_SECURE_HOST_NOT_FOUND = 11032, // 0x00002B18
        /// <summary>Name based IPSEC policy could not be added.</summary>
        WSA_IPSEC_NAME_POLICY_ERROR = 11033, // 0x00002B19
        /// <summary>No more handles could be generated at this time.</summary>
        ERROR_INTERNET_OUT_OF_HANDLES = 12001, // 0x00002EE1
        /// <summary>The request has timed out.</summary>
        ERROR_INTERNET_TIMEOUT = 12002, // 0x00002EE2
        /// <summary>
        /// An extended error was returned from the server. This is typically a string or buffer containing a verbose error message. Call \nInternetGetLastResponseInfo to retrieve the error text.
        /// </summary>
        ERROR_INTERNET_EXTENDED_ERROR = 12003, // 0x00002EE3
        /// <summary>An internal error has occurred.</summary>
        ERROR_INTERNET_INTERNAL_ERROR = 12004, // 0x00002EE4
        /// <summary>The URL is invalid.</summary>
        ERROR_INTERNET_INVALID_URL = 12005, // 0x00002EE5
        /// <summary>
        /// The URL scheme could not be recognized, or is not supported.
        /// </summary>
        ERROR_INTERNET_UNRECOGNIZED_SCHEME = 12006, // 0x00002EE6
        /// <summary>The server name could not be resolved.</summary>
        ERROR_INTERNET_NAME_NOT_RESOLVED = 12007, // 0x00002EE7
        /// <summary>The requested protocol could not be located.</summary>
        ERROR_INTERNET_PROTOCOL_NOT_FOUND = 12008, // 0x00002EE8
        /// <summary>
        /// A request to \nInternetQueryOption or \nInternetSetOption specified an invalid option value.
        /// </summary>
        ERROR_INTERNET_INVALID_OPTION = 12009, // 0x00002EE9
        /// <summary>
        /// The length of an option supplied to \nInternetQueryOption or \nInternetSetOption is incorrect for the type of option specified.
        /// </summary>
        ERROR_INTERNET_BAD_OPTION_LENGTH = 12010, // 0x00002EEA
        /// <summary>The requested option cannot be set, only queried.</summary>
        ERROR_INTERNET_OPTION_NOT_SETTABLE = 12011, // 0x00002EEB
        /// <summary>WinINet support is being shut down or unloaded.</summary>
        ERROR_INTERNET_SHUTDOWN = 12012, // 0x00002EEC
        /// <summary>
        /// The request to connect and log on to an FTP server could not be completed because the supplied user name is incorrect.
        /// </summary>
        ERROR_INTERNET_INCORRECT_USER_NAME = 12013, // 0x00002EED
        /// <summary>
        /// The request to connect and log on to an FTP server could not be completed because the supplied password is incorrect.
        /// </summary>
        ERROR_INTERNET_INCORRECT_PASSWORD = 12014, // 0x00002EEE
        /// <summary>
        /// The request to connect and log on to an FTP server failed.
        /// </summary>
        ERROR_INTERNET_LOGIN_FAILURE = 12015, // 0x00002EEF
        /// <summary>The requested operation is invalid.</summary>
        ERROR_INTERNET_INVALID_OPERATION = 12016, // 0x00002EF0
        /// <summary>
        /// The operation was canceled, usually because the handle on which the request was operating was closed before the operation completed.
        /// </summary>
        ERROR_INTERNET_OPERATION_CANCELLED = 12017, // 0x00002EF1
        /// <summary>
        /// The type of handle supplied is incorrect for this operation.
        /// </summary>
        ERROR_INTERNET_INCORRECT_HANDLE_TYPE = 12018, // 0x00002EF2
        /// <summary>
        /// The requested operation cannot be carried out because the handle supplied is not in the correct state.
        /// </summary>
        ERROR_INTERNET_INCORRECT_HANDLE_STATE = 12019, // 0x00002EF3
        /// <summary>The request cannot be made via a proxy.</summary>
        ERROR_INTERNET_NOT_PROXY_REQUEST = 12020, // 0x00002EF4
        /// <summary>A required registry value could not be located.</summary>
        ERROR_INTERNET_REGISTRY_VALUE_NOT_FOUND = 12021, // 0x00002EF5
        /// <summary>
        /// A required registry value was located but is an incorrect type or has an invalid value.
        /// </summary>
        ERROR_INTERNET_BAD_REGISTRY_PARAMETER = 12022, // 0x00002EF6
        /// <summary>Direct network access cannot be made at this time.</summary>
        ERROR_INTERNET_NO_DIRECT_ACCESS = 12023, // 0x00002EF7
        /// <summary>
        /// An asynchronous request could not be made because a zero context value was supplied.
        /// </summary>
        ERROR_INTERNET_NO_CONTEXT = 12024, // 0x00002EF8
        /// <summary>
        /// An asynchronous request could not be made because a callback function has not been set.
        /// </summary>
        ERROR_INTERNET_NO_CALLBACK = 12025, // 0x00002EF9
        /// <summary>
        /// The required operation could not be completed because one or more requests are pending.
        /// </summary>
        ERROR_INTERNET_REQUEST_PENDING = 12026, // 0x00002EFA
        /// <summary>The format of the request is invalid.</summary>
        ERROR_INTERNET_INCORRECT_FORMAT = 12027, // 0x00002EFB
        /// <summary>The requested item could not be located.</summary>
        ERROR_INTERNET_ITEM_NOT_FOUND = 12028, // 0x00002EFC
        /// <summary>The attempt to connect to the server failed.</summary>
        ERROR_INTERNET_CANNOT_CONNECT = 12029, // 0x00002EFD
        /// <summary>The connection with the server has been terminated.</summary>
        ERROR_INTERNET_CONNECTION_ABORTED = 12030, // 0x00002EFE
        /// <summary>The connection with the server has been reset.</summary>
        ERROR_INTERNET_CONNECTION_RESET = 12031, // 0x00002EFF
        /// <summary>The function needs to redo the request.</summary>
        ERROR_INTERNET_FORCE_RETRY = 12032, // 0x00002F00
        /// <summary>The request to the proxy was invalid.</summary>
        ERROR_INTERNET_INVALID_PROXY_REQUEST = 12033, // 0x00002F01
        /// <summary>
        /// A user interface or other blocking operation has been requested.Note  Windows Vista and Windows Server 2008 and earlier only.
        /// </summary>
        ERROR_INTERNET_NEED_UI = 12034, // 0x00002F02
        /// <summary>The request failed because the handle already exists.</summary>
        ERROR_INTERNET_HANDLE_EXISTS = 12036, // 0x00002F04
        /// <summary>
        /// SSL certificate date that was received from the server is bad. The certificate is expired.
        /// </summary>
        ERROR_INTERNET_SEC_CERT_DATE_INVALID = 12037, // 0x00002F05
        /// <summary>
        /// SSL certificate common name (host name field) is incorrect—for example, if you entered www.server.com and the common name on the certificate says www.different.com.
        /// </summary>
        ERROR_INTERNET_SEC_CERT_CN_INVALID = 12038, // 0x00002F06
        /// <summary>
        /// The application is moving from a non-SSL to an SSL connection because of a redirect.
        /// </summary>
        ERROR_INTERNET_HTTP_TO_HTTPS_ON_REDIR = 12039, // 0x00002F07
        /// <summary>
        /// The application is moving from an SSL to an non-SSL connection because of a redirect.
        /// </summary>
        ERROR_INTERNET_HTTPS_TO_HTTP_ON_REDIR = 12040, // 0x00002F08
        /// <summary>
        /// The content is not entirely secure. Some of the content being viewed may have come from unsecured servers.
        /// </summary>
        ERROR_INTERNET_MIXED_SECURITY = 12041, // 0x00002F09
        /// <summary>
        /// The application is posting and attempting to change multiple lines of text on a server that is not secure.
        /// </summary>
        ERROR_INTERNET_CHG_POST_IS_NON_SECURE = 12042, // 0x00002F0A
        /// <summary>
        /// The application is posting data to a server that is not secure.
        /// </summary>
        ERROR_INTERNET_POST_IS_NON_SECURE = 12043, // 0x00002F0B
        /// <summary>The server is requesting client authentication.</summary>
        ERROR_INTERNET_CLIENT_AUTH_CERT_NEEDED = 12044, // 0x00002F0C
        /// <summary>
        /// The function is unfamiliar with the Certificate Authority that generated the server's certificate.
        /// </summary>
        ERROR_INTERNET_INVALID_CA = 12045, // 0x00002F0D
        /// <summary>Client authorization is not set up on this computer.</summary>
        ERROR_INTERNET_CLIENT_AUTH_NOT_SETUP = 12046, // 0x00002F0E
        /// <summary>
        /// The application could not start an asynchronous thread.
        /// </summary>
        ERROR_INTERNET_ASYNC_THREAD_FAILED = 12047, // 0x00002F0F
        /// <summary>
        /// The function could not handle the redirection, because the scheme changed (for example, HTTP to FTP).
        /// </summary>
        ERROR_INTERNET_REDIRECT_SCHEME_CHANGE = 12048, // 0x00002F10
        /// <summary>Another thread has a password dialog box in progress.</summary>
        ERROR_INTERNET_DIALOG_PENDING = 12049, // 0x00002F11
        /// <summary>The dialog box should be retried.</summary>
        ERROR_INTERNET_RETRY_DIALOG = 12050, // 0x00002F12
        /// <summary>
        /// The data being submitted to an SSL connection is being redirected to a non-SSL connection.
        /// </summary>
        ERROR_INTERNET_HTTPS_HTTP_SUBMIT_REDIR = 12052, // 0x00002F14
        /// <summary>
        /// The request requires a CD-ROM to be inserted in the CD-ROM drive to locate the resource requested.Note  Windows Vista and Windows Server 2008 and earlier only.
        /// </summary>
        ERROR_INTERNET_INSERT_CDROM = 12053, // 0x00002F15
        /// <summary>
        /// The requested resource requires Fortezza authentication.
        /// </summary>
        ERROR_INTERNET_FORTEZZA_LOGIN_NEEDED = 12054, // 0x00002F16
        /// <summary>The SSL certificate contains errors.</summary>
        ERROR_INTERNET_SEC_CERT_ERRORS = 12055, // 0x00002F17
        /// <summary>The SSL certificate was not revoked.</summary>
        ERROR_INTERNET_SEC_CERT_NO_REV = 12056, // 0x00002F18
        /// <summary>Revocation of the SSL certificate failed.</summary>
        ERROR_INTERNET_SEC_CERT_REV_FAILED = 12057, // 0x00002F19
        /// <summary>
        /// The requested operation cannot be made on the FTP session handle because an operation is already in progress.
        /// </summary>
        ERROR_FTP_TRANSFER_IN_PROGRESS = 12110, // 0x00002F4E
        /// <summary>
        /// The FTP operation was not completed because the session was aborted.
        /// </summary>
        ERROR_FTP_DROPPED = 12111, // 0x00002F4F
        /// <summary>Passive mode is not available on the server.</summary>
        ERROR_FTP_NO_PASSIVE_MODE = 12112, // 0x00002F50
        /// <summary>
        /// An error was detected while parsing data returned from the Gopher server.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.
        /// </summary>
        ERROR_GOPHER_PROTOCOL_ERROR = 12130, // 0x00002F62
        /// <summary>
        /// The request must be made for a file locator.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.
        /// </summary>
        ERROR_GOPHER_NOT_FILE = 12131, // 0x00002F63
        /// <summary>
        /// An error was detected while receiving data from the Gopher server.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.
        /// </summary>
        ERROR_GOPHER_DATA_ERROR = 12132, // 0x00002F64
        /// <summary>
        /// The end of the data has been reached.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.
        /// </summary>
        ERROR_GOPHER_END_OF_DATA = 12133, // 0x00002F65
        /// <summary>
        /// The supplied locator is not valid.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.
        /// </summary>
        ERROR_GOPHER_INVALID_LOCATOR = 12134, // 0x00002F66
        /// <summary>
        /// The type of the locator is not correct for this operation.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.
        /// </summary>
        ERROR_GOPHER_INCORRECT_LOCATOR_TYPE = 12135, // 0x00002F67
        /// <summary>
        /// The requested operation can be made only against a Gopher+ server, or with a locator that specifies a Gopher+ operation.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.
        /// </summary>
        ERROR_GOPHER_NOT_GOPHER_PLUS = 12136, // 0x00002F68
        /// <summary>
        /// The requested attribute could not be located.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.
        /// </summary>
        ERROR_GOPHER_ATTRIBUTE_NOT_FOUND = 12137, // 0x00002F69
        /// <summary>
        /// The locator type is unknown.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.
        /// </summary>
        ERROR_GOPHER_UNKNOWN_LOCATOR = 12138, // 0x00002F6A
        /// <summary>The requested header could not be located.</summary>
        ERROR_HTTP_HEADER_NOT_FOUND = 12150, // 0x00002F76
        /// <summary>The server did not return any headers.</summary>
        ERROR_HTTP_DOWNLEVEL_SERVER = 12151, // 0x00002F77
        /// <summary>The server response could not be parsed.</summary>
        ERROR_HTTP_INVALID_SERVER_RESPONSE = 12152, // 0x00002F78
        /// <summary>The supplied header is invalid.</summary>
        ERROR_HTTP_INVALID_HEADER = 12153, // 0x00002F79
        /// <summary>The request made to \nHttpQueryInfo is invalid.</summary>
        ERROR_HTTP_INVALID_QUERY_REQUEST = 12154, // 0x00002F7A
        /// <summary>
        /// The header could not be added because it already exists.
        /// </summary>
        ERROR_HTTP_HEADER_ALREADY_EXISTS = 12155, // 0x00002F7B
        /// <summary>
        /// The redirection failed because either the scheme changed (for example, HTTP to FTP) or all attempts made to redirect failed (default is five attempts).
        /// </summary>
        ERROR_HTTP_REDIRECT_FAILED = 12156, // 0x00002F7C
        /// <summary>
        /// The application experienced an internal error loading the SSL libraries.
        /// </summary>
        ERROR_INTERNET_SECURITY_CHANNEL_ERROR = 12157, // 0x00002F7D
        /// <summary>The function was unable to cache the file.</summary>
        ERROR_INTERNET_UNABLE_TO_CACHE_FILE = 12158, // 0x00002F7E
        /// <summary>
        /// The required protocol stack is not loaded and the application cannot start WinSock.
        /// </summary>
        ERROR_INTERNET_TCPIP_NOT_INSTALLED = 12159, // 0x00002F7F
        /// <summary>The HTTP request was not redirected.</summary>
        ERROR_HTTP_NOT_REDIRECTED = 12160, // 0x00002F80
        /// <summary>
        /// The HTTP cookie requires confirmation.\nNote  Windows Vista and Windows Server 2008 and earlier only.
        /// </summary>
        ERROR_HTTP_COOKIE_NEEDS_CONFIRMATION = 12161, // 0x00002F81
        /// <summary>The HTTP cookie was declined by the server.</summary>
        ERROR_HTTP_COOKIE_DECLINED = 12162, // 0x00002F82
        /// <summary>The Internet connection has been lost.</summary>
        ERROR_INTERNET_DISCONNECTED = 12163, // 0x00002F83
        /// <summary>The website or server indicated is unreachable.</summary>
        ERROR_INTERNET_SERVER_UNREACHABLE = 12164, // 0x00002F84
        /// <summary>The designated proxy server cannot be reached.</summary>
        ERROR_INTERNET_PROXY_SERVER_UNREACHABLE = 12165, // 0x00002F85
        /// <summary>
        /// There was an error in the automatic proxy configuration script.
        /// </summary>
        ERROR_INTERNET_BAD_AUTO_PROXY_SCRIPT = 12166, // 0x00002F86
        /// <summary>
        /// The automatic proxy configuration script could not be downloaded. The INTERNET_FLAG_MUST_CACHE_REQUEST flag was set.
        /// </summary>
        ERROR_INTERNET_UNABLE_TO_DOWNLOAD_SCRIPT = 12167, // 0x00002F87
        /// <summary>The redirection requires user confirmation.</summary>
        ERROR_HTTP_REDIRECT_NEEDS_CONFIRMATION = 12168, // 0x00002F88
        /// <summary>The SSL certificate is invalid.</summary>
        ERROR_INTERNET_SEC_INVALID_CERT = 12169, // 0x00002F89
        /// <summary>The SSL certificate was revoked.</summary>
        ERROR_INTERNET_SEC_CERT_REVOKED = 12170, // 0x00002F8A
        /// <summary>The function failed due to a security check.</summary>
        ERROR_INTERNET_FAILED_DUETOSECURITYCHECK = 12171, // 0x00002F8B
        /// <summary>
        /// Initialization of the WinINet API has not occurred. Indicates that a higher-level function, such as \nInternetOpen, has not been called yet.
        /// </summary>
        ERROR_INTERNET_NOT_INITIALIZED = 12172, // 0x00002F8C
        /// <summary>Not currently implemented.</summary>
        ERROR_INTERNET_NEED_MSN_SSPI_PKG = 12173, // 0x00002F8D
        /// <summary>
        /// The MS-Logoff digest header has been returned from the website. This header specifically instructs the digest package to purge credentials for the associated realm. This error will only be returned if \nINTERNET_ERROR_MASK_LOGIN_FAILURE_DISPLAY_ENTITY_BODY option has been set; otherwise, ERROR_INTERNET_LOGIN_FAILURE is returned.
        /// </summary>
        ERROR_INTERNET_LOGIN_FAILURE_DISPLAY_ENTITY_BODY = 12174, // 0x00002F8E
        /// <summary>
        /// WinINet failed to perform content decoding on the response. For more information, see the Content Encoding topic.
        /// </summary>
        ERROR_INTERNET_DECODING_FAILED = 12175, // 0x00002F8F
        /// <summary>The specified quick mode policy already exists.</summary>
        ERROR_IPSEC_QM_POLICY_EXISTS = 13000, // 0x000032C8
        /// <summary>The specified quick mode policy was not found.</summary>
        ERROR_IPSEC_QM_POLICY_NOT_FOUND = 13001, // 0x000032C9
        /// <summary>The specified quick mode policy is being used.</summary>
        ERROR_IPSEC_QM_POLICY_IN_USE = 13002, // 0x000032CA
        /// <summary>The specified main mode policy already exists.</summary>
        ERROR_IPSEC_MM_POLICY_EXISTS = 13003, // 0x000032CB
        /// <summary>The specified main mode policy was not found.</summary>
        ERROR_IPSEC_MM_POLICY_NOT_FOUND = 13004, // 0x000032CC
        /// <summary>The specified main mode policy is being used.</summary>
        ERROR_IPSEC_MM_POLICY_IN_USE = 13005, // 0x000032CD
        /// <summary>The specified main mode filter already exists.</summary>
        ERROR_IPSEC_MM_FILTER_EXISTS = 13006, // 0x000032CE
        /// <summary>The specified main mode filter was not found.</summary>
        ERROR_IPSEC_MM_FILTER_NOT_FOUND = 13007, // 0x000032CF
        /// <summary>The specified transport mode filter already exists.</summary>
        ERROR_IPSEC_TRANSPORT_FILTER_EXISTS = 13008, // 0x000032D0
        /// <summary>The specified transport mode filter does not exist.</summary>
        ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND = 13009, // 0x000032D1
        /// <summary>The specified main mode authentication list exists.</summary>
        ERROR_IPSEC_MM_AUTH_EXISTS = 13010, // 0x000032D2
        /// <summary>
        /// The specified main mode authentication list was not found.
        /// </summary>
        ERROR_IPSEC_MM_AUTH_NOT_FOUND = 13011, // 0x000032D3
        /// <summary>
        /// The specified main mode authentication list is being used.
        /// </summary>
        ERROR_IPSEC_MM_AUTH_IN_USE = 13012, // 0x000032D4
        /// <summary>The specified default main mode policy was not found.</summary>
        ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND = 13013, // 0x000032D5
        /// <summary>
        /// The specified default main mode authentication list was not found.
        /// </summary>
        ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND = 13014, // 0x000032D6
        /// <summary>
        /// The specified default quick mode policy was not found.
        /// </summary>
        ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND = 13015, // 0x000032D7
        /// <summary>The specified tunnel mode filter exists.</summary>
        ERROR_IPSEC_TUNNEL_FILTER_EXISTS = 13016, // 0x000032D8
        /// <summary>The specified tunnel mode filter was not found.</summary>
        ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND = 13017, // 0x000032D9
        /// <summary>The Main Mode filter is pending deletion.</summary>
        ERROR_IPSEC_MM_FILTER_PENDING_DELETION = 13018, // 0x000032DA
        /// <summary>The transport filter is pending deletion.</summary>
        ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION = 13019, // 0x000032DB
        /// <summary>The tunnel filter is pending deletion.</summary>
        ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION = 13020, // 0x000032DC
        /// <summary>The Main Mode policy is pending deletion.</summary>
        ERROR_IPSEC_MM_POLICY_PENDING_DELETION = 13021, // 0x000032DD
        /// <summary>
        /// The Main Mode authentication bundle is pending deletion.
        /// </summary>
        ERROR_IPSEC_MM_AUTH_PENDING_DELETION = 13022, // 0x000032DE
        /// <summary>The Quick Mode policy is pending deletion.</summary>
        ERROR_IPSEC_QM_POLICY_PENDING_DELETION = 13023, // 0x000032DF
        /// <summary>
        /// The Main Mode policy was successfully added, but some of the requested offers are not supported.
        /// </summary>
        WARNING_IPSEC_MM_POLICY_PRUNED = 13024, // 0x000032E0
        /// <summary>
        /// The Quick Mode policy was successfully added, but some of the requested offers are not supported.
        /// </summary>
        WARNING_IPSEC_QM_POLICY_PRUNED = 13025, // 0x000032E1
        /// <summary>ERROR_IPSEC_IKE_NEG_STATUS_BEGIN</summary>
        ERROR_IPSEC_IKE_NEG_STATUS_BEGIN = 13800, // 0x000035E8
        /// <summary>IKE authentication credentials are unacceptable.</summary>
        ERROR_IPSEC_IKE_AUTH_FAIL = 13801, // 0x000035E9
        /// <summary>IKE security attributes are unacceptable.</summary>
        ERROR_IPSEC_IKE_ATTRIB_FAIL = 13802, // 0x000035EA
        /// <summary>IKE Negotiation in progress.</summary>
        ERROR_IPSEC_IKE_NEGOTIATION_PENDING = 13803, // 0x000035EB
        /// <summary>General processing error.</summary>
        ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR = 13804, // 0x000035EC
        /// <summary>Negotiation timed out.</summary>
        ERROR_IPSEC_IKE_TIMED_OUT = 13805, // 0x000035ED
        /// <summary>
        /// IKE failed to find valid machine certificate. Contact your Network Security Administrator about installing a valid certificate in the appropriate Certificate Store.
        /// </summary>
        ERROR_IPSEC_IKE_NO_CERT = 13806, // 0x000035EE
        /// <summary>
        /// IKE SA deleted by peer before establishment completed.
        /// </summary>
        ERROR_IPSEC_IKE_SA_DELETED = 13807, // 0x000035EF
        /// <summary>IKE SA deleted before establishment completed.</summary>
        ERROR_IPSEC_IKE_SA_REAPED = 13808, // 0x000035F0
        /// <summary>Negotiation request sat in Queue too long.</summary>
        ERROR_IPSEC_IKE_MM_ACQUIRE_DROP = 13809, // 0x000035F1
        /// <summary>Negotiation request sat in Queue too long.</summary>
        ERROR_IPSEC_IKE_QM_ACQUIRE_DROP = 13810, // 0x000035F2
        /// <summary>Negotiation request sat in Queue too long.</summary>
        ERROR_IPSEC_IKE_QUEUE_DROP_MM = 13811, // 0x000035F3
        /// <summary>Negotiation request sat in Queue too long.</summary>
        ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM = 13812, // 0x000035F4
        /// <summary>No response from peer.</summary>
        ERROR_IPSEC_IKE_DROP_NO_RESPONSE = 13813, // 0x000035F5
        /// <summary>Negotiation took too long.</summary>
        ERROR_IPSEC_IKE_MM_DELAY_DROP = 13814, // 0x000035F6
        /// <summary>Negotiation took too long.</summary>
        ERROR_IPSEC_IKE_QM_DELAY_DROP = 13815, // 0x000035F7
        /// <summary>Unknown error occurred.</summary>
        ERROR_IPSEC_IKE_ERROR = 13816, // 0x000035F8
        /// <summary>Certificate Revocation Check failed.</summary>
        ERROR_IPSEC_IKE_CRL_FAILED = 13817, // 0x000035F9
        /// <summary>Invalid certificate key usage.</summary>
        ERROR_IPSEC_IKE_INVALID_KEY_USAGE = 13818, // 0x000035FA
        /// <summary>Invalid certificate type.</summary>
        ERROR_IPSEC_IKE_INVALID_CERT_TYPE = 13819, // 0x000035FB
        /// <summary>
        /// IKE negotiation failed because the machine certificate used does not have a private key. IPsec certificates require a private key. Contact your Network Security administrator about replacing with a certificate that has a private key.
        /// </summary>
        ERROR_IPSEC_IKE_NO_PRIVATE_KEY = 13820, // 0x000035FC
        /// <summary>Simultaneous rekeys were detected.</summary>
        ERROR_IPSEC_IKE_SIMULTANEOUS_REKEY = 13821, // 0x000035FD
        /// <summary>Failure in Diffie-Hellman computation.</summary>
        ERROR_IPSEC_IKE_DH_FAIL = 13822, // 0x000035FE
        /// <summary>Don't know how to process critical payload.</summary>
        ERROR_IPSEC_IKE_CRITICAL_PAYLOAD_NOT_RECOGNIZED = 13823, // 0x000035FF
        /// <summary>Invalid header.</summary>
        ERROR_IPSEC_IKE_INVALID_HEADER = 13824, // 0x00003600
        /// <summary>No policy configured.</summary>
        ERROR_IPSEC_IKE_NO_POLICY = 13825, // 0x00003601
        /// <summary>Failed to verify signature.</summary>
        ERROR_IPSEC_IKE_INVALID_SIGNATURE = 13826, // 0x00003602
        /// <summary>Failed to authenticate using Kerberos.</summary>
        ERROR_IPSEC_IKE_KERBEROS_ERROR = 13827, // 0x00003603
        /// <summary>Peer's certificate did not have a public key.</summary>
        ERROR_IPSEC_IKE_NO_PUBLIC_KEY = 13828, // 0x00003604
        /// <summary>Error processing error payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR = 13829, // 0x00003605
        /// <summary>Error processing SA payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_SA = 13830, // 0x00003606
        /// <summary>Error processing Proposal payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_PROP = 13831, // 0x00003607
        /// <summary>Error processing Transform payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_TRANS = 13832, // 0x00003608
        /// <summary>Error processing KE payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_KE = 13833, // 0x00003609
        /// <summary>Error processing ID payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_ID = 13834, // 0x0000360A
        /// <summary>Error processing Cert payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_CERT = 13835, // 0x0000360B
        /// <summary>Error processing Certificate Request payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ = 13836, // 0x0000360C
        /// <summary>Error processing Hash payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_HASH = 13837, // 0x0000360D
        /// <summary>Error processing Signature payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_SIG = 13838, // 0x0000360E
        /// <summary>Error processing Nonce payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_NONCE = 13839, // 0x0000360F
        /// <summary>Error processing Notify payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY = 13840, // 0x00003610
        /// <summary>Error processing Delete Payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_DELETE = 13841, // 0x00003611
        /// <summary>Error processing VendorId payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR = 13842, // 0x00003612
        /// <summary>Invalid payload received.</summary>
        ERROR_IPSEC_IKE_INVALID_PAYLOAD = 13843, // 0x00003613
        /// <summary>Soft SA loaded.</summary>
        ERROR_IPSEC_IKE_LOAD_SOFT_SA = 13844, // 0x00003614
        /// <summary>Soft SA torn down.</summary>
        ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN = 13845, // 0x00003615
        /// <summary>Invalid cookie received.</summary>
        ERROR_IPSEC_IKE_INVALID_COOKIE = 13846, // 0x00003616
        /// <summary>Peer failed to send valid machine certificate.</summary>
        ERROR_IPSEC_IKE_NO_PEER_CERT = 13847, // 0x00003617
        /// <summary>
        /// Certification Revocation check of peer's certificate failed.
        /// </summary>
        ERROR_IPSEC_IKE_PEER_CRL_FAILED = 13848, // 0x00003618
        /// <summary>New policy invalidated SAs formed with old policy.</summary>
        ERROR_IPSEC_IKE_POLICY_CHANGE = 13849, // 0x00003619
        /// <summary>There is no available Main Mode IKE policy.</summary>
        ERROR_IPSEC_IKE_NO_MM_POLICY = 13850, // 0x0000361A
        /// <summary>Failed to enabled TCB privilege.</summary>
        ERROR_IPSEC_IKE_NOTCBPRIV = 13851, // 0x0000361B
        /// <summary>Failed to load SECURITY.DLL.</summary>
        ERROR_IPSEC_IKE_SECLOADFAIL = 13852, // 0x0000361C
        /// <summary>
        /// Failed to obtain security function table dispatch address from SSPI.
        /// </summary>
        ERROR_IPSEC_IKE_FAILSSPINIT = 13853, // 0x0000361D
        /// <summary>
        /// Failed to query Kerberos package to obtain max token size.
        /// </summary>
        ERROR_IPSEC_IKE_FAILQUERYSSP = 13854, // 0x0000361E
        /// <summary>
        /// Failed to obtain Kerberos server credentials for ISAKMP/ERROR_IPSEC_IKE service. Kerberos authentication will not function. The most likely reason for this is lack of domain membership. This is normal if your computer is a member of a workgroup.
        /// </summary>
        ERROR_IPSEC_IKE_SRVACQFAIL = 13855, // 0x0000361F
        /// <summary>
        /// Failed to determine SSPI principal name for ISAKMP/ERROR_IPSEC_IKE service (QueryCredentialsAttributes).
        /// </summary>
        ERROR_IPSEC_IKE_SRVQUERYCRED = 13856, // 0x00003620
        /// <summary>
        /// Failed to obtain new SPI for the inbound SA from IPsec driver. The most common cause for this is that the driver does not have the correct filter. Check your policy to verify the filters.
        /// </summary>
        ERROR_IPSEC_IKE_GETSPIFAIL = 13857, // 0x00003621
        /// <summary>Given filter is invalid.</summary>
        ERROR_IPSEC_IKE_INVALID_FILTER = 13858, // 0x00003622
        /// <summary>Memory allocation failed.</summary>
        ERROR_IPSEC_IKE_OUT_OF_MEMORY = 13859, // 0x00003623
        /// <summary>
        /// Failed to add Security Association to IPsec Driver. The most common cause for this is if the IKE negotiation took too long to complete. If the problem persists, reduce the load on the faulting machine.
        /// </summary>
        ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED = 13860, // 0x00003624
        /// <summary>Invalid policy.</summary>
        ERROR_IPSEC_IKE_INVALID_POLICY = 13861, // 0x00003625
        /// <summary>Invalid DOI.</summary>
        ERROR_IPSEC_IKE_UNKNOWN_DOI = 13862, // 0x00003626
        /// <summary>Invalid situation.</summary>
        ERROR_IPSEC_IKE_INVALID_SITUATION = 13863, // 0x00003627
        /// <summary>Diffie-Hellman failure.</summary>
        ERROR_IPSEC_IKE_DH_FAILURE = 13864, // 0x00003628
        /// <summary>Invalid Diffie-Hellman group.</summary>
        ERROR_IPSEC_IKE_INVALID_GROUP = 13865, // 0x00003629
        /// <summary>Error encrypting payload.</summary>
        ERROR_IPSEC_IKE_ENCRYPT = 13866, // 0x0000362A
        /// <summary>Error decrypting payload.</summary>
        ERROR_IPSEC_IKE_DECRYPT = 13867, // 0x0000362B
        /// <summary>Policy match error.</summary>
        ERROR_IPSEC_IKE_POLICY_MATCH = 13868, // 0x0000362C
        /// <summary>Unsupported ID.</summary>
        ERROR_IPSEC_IKE_UNSUPPORTED_ID = 13869, // 0x0000362D
        /// <summary>Hash verification failed.</summary>
        ERROR_IPSEC_IKE_INVALID_HASH = 13870, // 0x0000362E
        /// <summary>Invalid hash algorithm.</summary>
        ERROR_IPSEC_IKE_INVALID_HASH_ALG = 13871, // 0x0000362F
        /// <summary>Invalid hash size.</summary>
        ERROR_IPSEC_IKE_INVALID_HASH_SIZE = 13872, // 0x00003630
        /// <summary>Invalid encryption algorithm.</summary>
        ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG = 13873, // 0x00003631
        /// <summary>Invalid authentication algorithm.</summary>
        ERROR_IPSEC_IKE_INVALID_AUTH_ALG = 13874, // 0x00003632
        /// <summary>Invalid certificate signature.</summary>
        ERROR_IPSEC_IKE_INVALID_SIG = 13875, // 0x00003633
        /// <summary>Load failed.</summary>
        ERROR_IPSEC_IKE_LOAD_FAILED = 13876, // 0x00003634
        /// <summary>Deleted via RPC call.</summary>
        ERROR_IPSEC_IKE_RPC_DELETE = 13877, // 0x00003635
        /// <summary>
        /// Temporary state created to perform reinitialization. This is not a real failure.
        /// </summary>
        ERROR_IPSEC_IKE_BENIGN_REINIT = 13878, // 0x00003636
        /// <summary>
        /// The lifetime value received in the Responder Lifetime Notify is below the Windows 2000 configured minimum value. Please fix the policy on the peer machine.
        /// </summary>
        ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY = 13879, // 0x00003637
        /// <summary>
        /// The recipient cannot handle version of IKE specified in the header.
        /// </summary>
        ERROR_IPSEC_IKE_INVALID_MAJOR_VERSION = 13880, // 0x00003638
        /// <summary>
        /// Key length in certificate is too small for configured security requirements.
        /// </summary>
        ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN = 13881, // 0x00003639
        /// <summary>Max number of established MM SAs to peer exceeded.</summary>
        ERROR_IPSEC_IKE_MM_LIMIT = 13882, // 0x0000363A
        /// <summary>IKE received a policy that disables negotiation.</summary>
        ERROR_IPSEC_IKE_NEGOTIATION_DISABLED = 13883, // 0x0000363B
        /// <summary>
        /// Reached maximum quick mode limit for the main mode. New main mode will be started.
        /// </summary>
        ERROR_IPSEC_IKE_QM_LIMIT = 13884, // 0x0000363C
        /// <summary>
        /// Main mode SA lifetime expired or peer sent a main mode delete.
        /// </summary>
        ERROR_IPSEC_IKE_MM_EXPIRED = 13885, // 0x0000363D
        /// <summary>
        /// Main mode SA assumed to be invalid because peer stopped responding.
        /// </summary>
        ERROR_IPSEC_IKE_PEER_MM_ASSUMED_INVALID = 13886, // 0x0000363E
        /// <summary>
        /// Certificate doesn't chain to a trusted root in IPsec policy.
        /// </summary>
        ERROR_IPSEC_IKE_CERT_CHAIN_POLICY_MISMATCH = 13887, // 0x0000363F
        /// <summary>Received unexpected message ID.</summary>
        ERROR_IPSEC_IKE_UNEXPECTED_MESSAGE_ID = 13888, // 0x00003640
        /// <summary>Received invalid authentication offers.</summary>
        ERROR_IPSEC_IKE_INVALID_AUTH_PAYLOAD = 13889, // 0x00003641
        /// <summary>Sent DoS cookie notify to initiator.</summary>
        ERROR_IPSEC_IKE_DOS_COOKIE_SENT = 13890, // 0x00003642
        /// <summary>IKE service is shutting down.</summary>
        ERROR_IPSEC_IKE_SHUTTING_DOWN = 13891, // 0x00003643
        /// <summary>
        /// Could not verify binding between CGA address and certificate.
        /// </summary>
        ERROR_IPSEC_IKE_CGA_AUTH_FAILED = 13892, // 0x00003644
        /// <summary>Error processing NatOA payload.</summary>
        ERROR_IPSEC_IKE_PROCESS_ERR_NATOA = 13893, // 0x00003645
        /// <summary>
        /// Parameters of the main mode are invalid for this quick mode.
        /// </summary>
        ERROR_IPSEC_IKE_INVALID_MM_FOR_QM = 13894, // 0x00003646
        /// <summary>Quick mode SA was expired by IPsec driver.</summary>
        ERROR_IPSEC_IKE_QM_EXPIRED = 13895, // 0x00003647
        /// <summary>
        /// Too many dynamically added IKEEXT filters were detected.
        /// </summary>
        ERROR_IPSEC_IKE_TOO_MANY_FILTERS = 13896, // 0x00003648
        /// <summary>ERROR_IPSEC_IKE_NEG_STATUS_END</summary>
        ERROR_IPSEC_IKE_NEG_STATUS_END = 13897, // 0x00003649
        /// <summary>
        /// NAP reauth succeeded and must delete the dummy NAP IKEv2 tunnel.
        /// </summary>
        ERROR_IPSEC_IKE_KILL_DUMMY_NAP_TUNNEL = 13898, // 0x0000364A
        /// <summary>
        /// Error in assigning inner IP address to initiator in tunnel mode.
        /// </summary>
        ERROR_IPSEC_IKE_INNER_IP_ASSIGNMENT_FAILURE = 13899, // 0x0000364B
        /// <summary>Require configuration payload missing.</summary>
        ERROR_IPSEC_IKE_REQUIRE_CP_PAYLOAD_MISSING = 13900, // 0x0000364C
        /// <summary>
        /// A negotiation running as the security principle who issued the connection is in progress.
        /// </summary>
        ERROR_IPSEC_KEY_MODULE_IMPERSONATION_NEGOTIATION_PENDING = 13901, // 0x0000364D
        /// <summary>
        /// SA was deleted due to IKEv1/AuthIP co-existence suppress check.
        /// </summary>
        ERROR_IPSEC_IKE_COEXISTENCE_SUPPRESS = 13902, // 0x0000364E
        /// <summary>
        /// Incoming SA request was dropped due to peer IP address rate limiting.
        /// </summary>
        ERROR_IPSEC_IKE_RATELIMIT_DROP = 13903, // 0x0000364F
        /// <summary>Peer does not support MOBIKE.</summary>
        ERROR_IPSEC_IKE_PEER_DOESNT_SUPPORT_MOBIKE = 13904, // 0x00003650
        /// <summary>SA establishment is not authorized.</summary>
        ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE = 13905, // 0x00003651
        /// <summary>
        /// SA establishment is not authorized because there is not a sufficiently strong PKINIT-based credential.
        /// </summary>
        ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_FAILURE = 13906, // 0x00003652
        /// <summary>
        /// SA establishment is not authorized.  You may need to enter updated or different credentials such as a smartcard.
        /// </summary>
        ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE_WITH_OPTIONAL_RETRY = 13907, // 0x00003653
        /// <summary>
        /// SA establishment is not authorized because there is not a sufficiently strong PKINIT-based credential. This might be related to certificate-to-account mapping failure for the SA.
        /// </summary>
        ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_AND_CERTMAP_FAILURE = 13908, // 0x00003654
        /// <summary>ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END</summary>
        ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END = 13909, // 0x00003655
        /// <summary>
        /// The SPI in the packet does not match a valid IPsec SA.
        /// </summary>
        ERROR_IPSEC_BAD_SPI = 13910, // 0x00003656
        /// <summary>
        /// Packet was received on an IPsec SA whose lifetime has expired.
        /// </summary>
        ERROR_IPSEC_SA_LIFETIME_EXPIRED = 13911, // 0x00003657
        /// <summary>
        /// Packet was received on an IPsec SA that does not match the packet characteristics.
        /// </summary>
        ERROR_IPSEC_WRONG_SA = 13912, // 0x00003658
        /// <summary>Packet sequence number replay check failed.</summary>
        ERROR_IPSEC_REPLAY_CHECK_FAILED = 13913, // 0x00003659
        /// <summary>IPsec header and/or trailer in the packet is invalid.</summary>
        ERROR_IPSEC_INVALID_PACKET = 13914, // 0x0000365A
        /// <summary>IPsec integrity check failed.</summary>
        ERROR_IPSEC_INTEGRITY_CHECK_FAILED = 13915, // 0x0000365B
        /// <summary>IPsec dropped a clear text packet.</summary>
        ERROR_IPSEC_CLEAR_TEXT_DROP = 13916, // 0x0000365C
        /// <summary>
        /// IPsec dropped an incoming ESP packet in authenticated firewall mode. This drop is benign.
        /// </summary>
        ERROR_IPSEC_AUTH_FIREWALL_DROP = 13917, // 0x0000365D
        /// <summary>IPsec dropped a packet due to DoS throttling.</summary>
        ERROR_IPSEC_THROTTLE_DROP = 13918, // 0x0000365E
        /// <summary>IPsec DoS Protection matched an explicit block rule.</summary>
        ERROR_IPSEC_DOSP_BLOCK = 13925, // 0x00003665
        /// <summary>
        /// IPsec DoS Protection received an IPsec specific multicast packet which is not allowed.
        /// </summary>
        ERROR_IPSEC_DOSP_RECEIVED_MULTICAST = 13926, // 0x00003666
        /// <summary>
        /// IPsec DoS Protection received an incorrectly formatted packet.
        /// </summary>
        ERROR_IPSEC_DOSP_INVALID_PACKET = 13927, // 0x00003667
        /// <summary>IPsec DoS Protection failed to look up state.</summary>
        ERROR_IPSEC_DOSP_STATE_LOOKUP_FAILED = 13928, // 0x00003668
        /// <summary>
        /// IPsec DoS Protection failed to create state because the maximum number of entries allowed by policy has been reached.
        /// </summary>
        ERROR_IPSEC_DOSP_MAX_ENTRIES = 13929, // 0x00003669
        /// <summary>
        /// IPsec DoS Protection received an IPsec negotiation packet for a keying module which is not allowed by policy.
        /// </summary>
        ERROR_IPSEC_DOSP_KEYMOD_NOT_ALLOWED = 13930, // 0x0000366A
        /// <summary>IPsec DoS Protection has not been enabled.</summary>
        ERROR_IPSEC_DOSP_NOT_INSTALLED = 13931, // 0x0000366B
        /// <summary>
        /// IPsec DoS Protection failed to create a per internal IP rate limit queue because the maximum number of queues allowed by policy has been reached.
        /// </summary>
        ERROR_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES = 13932, // 0x0000366C
        /// <summary>
        /// The requested section was not present in the activation context.
        /// </summary>
        ERROR_SXS_SECTION_NOT_FOUND = 14000, // 0x000036B0
        /// <summary>
        /// The application has failed to start because its side-by-side configuration is incorrect. Please see the application event log or use the command-line sxstrace.exe tool for more detail.
        /// </summary>
        ERROR_SXS_CANT_GEN_ACTCTX = 14001, // 0x000036B1
        /// <summary>The application binding data format is invalid.</summary>
        ERROR_SXS_INVALID_ACTCTXDATA_FORMAT = 14002, // 0x000036B2
        /// <summary>
        /// The referenced assembly is not installed on your system.
        /// </summary>
        ERROR_SXS_ASSEMBLY_NOT_FOUND = 14003, // 0x000036B3
        /// <summary>
        /// The manifest file does not begin with the required tag and format information.
        /// </summary>
        ERROR_SXS_MANIFEST_FORMAT_ERROR = 14004, // 0x000036B4
        /// <summary>The manifest file contains one or more syntax errors.</summary>
        ERROR_SXS_MANIFEST_PARSE_ERROR = 14005, // 0x000036B5
        /// <summary>
        /// The application attempted to activate a disabled activation context.
        /// </summary>
        ERROR_SXS_ACTIVATION_CONTEXT_DISABLED = 14006, // 0x000036B6
        /// <summary>
        /// The requested lookup key was not found in any active activation context.
        /// </summary>
        ERROR_SXS_KEY_NOT_FOUND = 14007, // 0x000036B7
        /// <summary>
        /// A component version required by the application conflicts with another component version already active.
        /// </summary>
        ERROR_SXS_VERSION_CONFLICT = 14008, // 0x000036B8
        /// <summary>
        /// The type requested activation context section does not match the query API used.
        /// </summary>
        ERROR_SXS_WRONG_SECTION_TYPE = 14009, // 0x000036B9
        /// <summary>
        /// Lack of system resources has required isolated activation to be disabled for the current thread of execution.
        /// </summary>
        ERROR_SXS_THREAD_QUERIES_DISABLED = 14010, // 0x000036BA
        /// <summary>
        /// An attempt to set the process default activation context failed because the process default activation context was already set.
        /// </summary>
        ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET = 14011, // 0x000036BB
        /// <summary>
        /// The encoding group identifier specified is not recognized.
        /// </summary>
        ERROR_SXS_UNKNOWN_ENCODING_GROUP = 14012, // 0x000036BC
        /// <summary>The encoding requested is not recognized.</summary>
        ERROR_SXS_UNKNOWN_ENCODING = 14013, // 0x000036BD
        /// <summary>The manifest contains a reference to an invalid URI.</summary>
        ERROR_SXS_INVALID_XML_NAMESPACE_URI = 14014, // 0x000036BE
        /// <summary>
        /// The application manifest contains a reference to a dependent assembly which is not installed.
        /// </summary>
        ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14015, // 0x000036BF
        /// <summary>
        /// The manifest for an assembly used by the application has a reference to a dependent assembly which is not installed.
        /// </summary>
        ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14016, // 0x000036C0
        /// <summary>
        /// The manifest contains an attribute for the assembly identity which is not valid.
        /// </summary>
        ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE = 14017, // 0x000036C1
        /// <summary>
        /// The manifest is missing the required default namespace specification on the assembly element.
        /// </summary>
        ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE = 14018, // 0x000036C2
        /// <summary>
        /// The manifest has a default namespace specified on the assembly element but its value is not \"urn:schemas-microsoft-com:asm.v1\".
        /// </summary>
        ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE = 14019, // 0x000036C3
        /// <summary>
        /// The private manifest probed has crossed a path with an unsupported reparse point.
        /// </summary>
        ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT = 14020, // 0x000036C4
        /// <summary>
        /// Two or more components referenced directly or indirectly by the application manifest have files by the same name.
        /// </summary>
        ERROR_SXS_DUPLICATE_DLL_NAME = 14021, // 0x000036C5
        /// <summary>
        /// Two or more components referenced directly or indirectly by the application manifest have window classes with the same name.
        /// </summary>
        ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME = 14022, // 0x000036C6
        /// <summary>
        /// Two or more components referenced directly or indirectly by the application manifest have the same COM server CLSIDs.
        /// </summary>
        ERROR_SXS_DUPLICATE_CLSID = 14023, // 0x000036C7
        /// <summary>
        /// Two or more components referenced directly or indirectly by the application manifest have proxies for the same COM interface IIDs.
        /// </summary>
        ERROR_SXS_DUPLICATE_IID = 14024, // 0x000036C8
        /// <summary>
        /// Two or more components referenced directly or indirectly by the application manifest have the same COM type library TLBIDs.
        /// </summary>
        ERROR_SXS_DUPLICATE_TLBID = 14025, // 0x000036C9
        /// <summary>
        /// Two or more components referenced directly or indirectly by the application manifest have the same COM ProgIDs.
        /// </summary>
        ERROR_SXS_DUPLICATE_PROGID = 14026, // 0x000036CA
        /// <summary>
        /// Two or more components referenced directly or indirectly by the application manifest are different versions of the same component which is not permitted.
        /// </summary>
        ERROR_SXS_DUPLICATE_ASSEMBLY_NAME = 14027, // 0x000036CB
        /// <summary>
        /// A component's file does not match the verification information present in the component manifest.
        /// </summary>
        ERROR_SXS_FILE_HASH_MISMATCH = 14028, // 0x000036CC
        /// <summary>
        /// The policy manifest contains one or more syntax errors.
        /// </summary>
        ERROR_SXS_POLICY_PARSE_ERROR = 14029, // 0x000036CD
        /// <summary>
        /// Manifest Parse Error : A string literal was expected, but no opening quote character was found.
        /// </summary>
        ERROR_SXS_XML_E_MISSINGQUOTE = 14030, // 0x000036CE
        /// <summary>
        /// Manifest Parse Error : Incorrect syntax was used in a comment.
        /// </summary>
        ERROR_SXS_XML_E_COMMENTSYNTAX = 14031, // 0x000036CF
        /// <summary>
        /// Manifest Parse Error : A name was started with an invalid character.
        /// </summary>
        ERROR_SXS_XML_E_BADSTARTNAMECHAR = 14032, // 0x000036D0
        /// <summary>
        /// Manifest Parse Error : A name contained an invalid character.
        /// </summary>
        ERROR_SXS_XML_E_BADNAMECHAR = 14033, // 0x000036D1
        /// <summary>
        /// Manifest Parse Error : A string literal contained an invalid character.
        /// </summary>
        ERROR_SXS_XML_E_BADCHARINSTRING = 14034, // 0x000036D2
        /// <summary>
        /// Manifest Parse Error : Invalid syntax for an xml declaration.
        /// </summary>
        ERROR_SXS_XML_E_XMLDECLSYNTAX = 14035, // 0x000036D3
        /// <summary>
        /// Manifest Parse Error : An Invalid character was found in text content.
        /// </summary>
        ERROR_SXS_XML_E_BADCHARDATA = 14036, // 0x000036D4
        /// <summary>
        /// Manifest Parse Error : Required white space was missing.
        /// </summary>
        ERROR_SXS_XML_E_MISSINGWHITESPACE = 14037, // 0x000036D5
        /// <summary>
        /// Manifest Parse Error : The character '&gt;' was expected.
        /// </summary>
        ERROR_SXS_XML_E_EXPECTINGTAGEND = 14038, // 0x000036D6
        /// <summary>
        /// Manifest Parse Error : A semi colon character was expected.
        /// </summary>
        ERROR_SXS_XML_E_MISSINGSEMICOLON = 14039, // 0x000036D7
        /// <summary>Manifest Parse Error : Unbalanced parentheses.</summary>
        ERROR_SXS_XML_E_UNBALANCEDPAREN = 14040, // 0x000036D8
        /// <summary>Manifest Parse Error : Internal error.</summary>
        ERROR_SXS_XML_E_INTERNALERROR = 14041, // 0x000036D9
        /// <summary>
        /// Manifest Parse Error : Whitespace is not allowed at this location.
        /// </summary>
        ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE = 14042, // 0x000036DA
        /// <summary>
        /// Manifest Parse Error : End of file reached in invalid state for current encoding.
        /// </summary>
        ERROR_SXS_XML_E_INCOMPLETE_ENCODING = 14043, // 0x000036DB
        /// <summary>Manifest Parse Error : Missing parenthesis.</summary>
        ERROR_SXS_XML_E_MISSING_PAREN = 14044, // 0x000036DC
        /// <summary>
        /// Manifest Parse Error : A single or double closing quote character (\\' or \\\") is missing.
        /// </summary>
        ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE = 14045, // 0x000036DD
        /// <summary>
        /// Manifest Parse Error : Multiple colons are not allowed in a name.
        /// </summary>
        ERROR_SXS_XML_E_MULTIPLE_COLONS = 14046, // 0x000036DE
        /// <summary>
        /// Manifest Parse Error : Invalid character for decimal digit.
        /// </summary>
        ERROR_SXS_XML_E_INVALID_DECIMAL = 14047, // 0x000036DF
        /// <summary>
        /// Manifest Parse Error : Invalid character for hexadecimal digit.
        /// </summary>
        ERROR_SXS_XML_E_INVALID_HEXIDECIMAL = 14048, // 0x000036E0
        /// <summary>
        /// Manifest Parse Error : Invalid unicode character value for this platform.
        /// </summary>
        ERROR_SXS_XML_E_INVALID_UNICODE = 14049, // 0x000036E1
        /// <summary>Manifest Parse Error : Expecting whitespace or '?'.</summary>
        ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK = 14050, // 0x000036E2
        /// <summary>
        /// Manifest Parse Error : End tag was not expected at this location.
        /// </summary>
        ERROR_SXS_XML_E_UNEXPECTEDENDTAG = 14051, // 0x000036E3
        /// <summary>
        /// Manifest Parse Error : The following tags were not closed: %1.
        /// </summary>
        ERROR_SXS_XML_E_UNCLOSEDTAG = 14052, // 0x000036E4
        /// <summary>Manifest Parse Error : Duplicate attribute.</summary>
        ERROR_SXS_XML_E_DUPLICATEATTRIBUTE = 14053, // 0x000036E5
        /// <summary>
        /// Manifest Parse Error : Only one top level element is allowed in an XML document.
        /// </summary>
        ERROR_SXS_XML_E_MULTIPLEROOTS = 14054, // 0x000036E6
        /// <summary>
        /// Manifest Parse Error : Invalid at the top level of the document.
        /// </summary>
        ERROR_SXS_XML_E_INVALIDATROOTLEVEL = 14055, // 0x000036E7
        /// <summary>Manifest Parse Error : Invalid xml declaration.</summary>
        ERROR_SXS_XML_E_BADXMLDECL = 14056, // 0x000036E8
        /// <summary>
        /// Manifest Parse Error : XML document must have a top level element.
        /// </summary>
        ERROR_SXS_XML_E_MISSINGROOT = 14057, // 0x000036E9
        /// <summary>Manifest Parse Error : Unexpected end of file.</summary>
        ERROR_SXS_XML_E_UNEXPECTEDEOF = 14058, // 0x000036EA
        /// <summary>
        /// Manifest Parse Error : Parameter entities cannot be used inside markup declarations in an internal subset.
        /// </summary>
        ERROR_SXS_XML_E_BADPEREFINSUBSET = 14059, // 0x000036EB
        /// <summary>Manifest Parse Error : Element was not closed.</summary>
        ERROR_SXS_XML_E_UNCLOSEDSTARTTAG = 14060, // 0x000036EC
        /// <summary>
        /// Manifest Parse Error : End element was missing the character '&gt;'.
        /// </summary>
        ERROR_SXS_XML_E_UNCLOSEDENDTAG = 14061, // 0x000036ED
        /// <summary>
        /// Manifest Parse Error : A string literal was not closed.
        /// </summary>
        ERROR_SXS_XML_E_UNCLOSEDSTRING = 14062, // 0x000036EE
        /// <summary>Manifest Parse Error : A comment was not closed.</summary>
        ERROR_SXS_XML_E_UNCLOSEDCOMMENT = 14063, // 0x000036EF
        /// <summary>Manifest Parse Error : A declaration was not closed.</summary>
        ERROR_SXS_XML_E_UNCLOSEDDECL = 14064, // 0x000036F0
        /// <summary>
        /// Manifest Parse Error : A CDATA section was not closed.
        /// </summary>
        ERROR_SXS_XML_E_UNCLOSEDCDATA = 14065, // 0x000036F1
        /// <summary>
        /// Manifest Parse Error : The namespace prefix is not allowed to start with the reserved string \"xml\".
        /// </summary>
        ERROR_SXS_XML_E_RESERVEDNAMESPACE = 14066, // 0x000036F2
        /// <summary>
        /// Manifest Parse Error : System does not support the specified encoding.
        /// </summary>
        ERROR_SXS_XML_E_INVALIDENCODING = 14067, // 0x000036F3
        /// <summary>
        /// Manifest Parse Error : Switch from current encoding to specified encoding not supported.
        /// </summary>
        ERROR_SXS_XML_E_INVALIDSWITCH = 14068, // 0x000036F4
        /// <summary>
        /// Manifest Parse Error : The name 'xml' is reserved and must be lower case.
        /// </summary>
        ERROR_SXS_XML_E_BADXMLCASE = 14069, // 0x000036F5
        /// <summary>
        /// Manifest Parse Error : The standalone attribute must have the value 'yes' or 'no'.
        /// </summary>
        ERROR_SXS_XML_E_INVALID_STANDALONE = 14070, // 0x000036F6
        /// <summary>
        /// Manifest Parse Error : The standalone attribute cannot be used in external entities.
        /// </summary>
        ERROR_SXS_XML_E_UNEXPECTED_STANDALONE = 14071, // 0x000036F7
        /// <summary>Manifest Parse Error : Invalid version number.</summary>
        ERROR_SXS_XML_E_INVALID_VERSION = 14072, // 0x000036F8
        /// <summary>
        /// Manifest Parse Error : Missing equals sign between attribute and attribute value.
        /// </summary>
        ERROR_SXS_XML_E_MISSINGEQUALS = 14073, // 0x000036F9
        /// <summary>
        /// Assembly Protection Error : Unable to recover the specified assembly.
        /// </summary>
        ERROR_SXS_PROTECTION_RECOVERY_FAILED = 14074, // 0x000036FA
        /// <summary>
        /// Assembly Protection Error : The public key for an assembly was too short to be allowed.
        /// </summary>
        ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT = 14075, // 0x000036FB
        /// <summary>
        /// Assembly Protection Error : The catalog for an assembly is not valid, or does not match the assembly's manifest.
        /// </summary>
        ERROR_SXS_PROTECTION_CATALOG_NOT_VALID = 14076, // 0x000036FC
        /// <summary>
        /// An HRESULT could not be translated to a corresponding Win32 error code.
        /// </summary>
        ERROR_SXS_UNTRANSLATABLE_HRESULT = 14077, // 0x000036FD
        /// <summary>
        /// Assembly Protection Error : The catalog for an assembly is missing.
        /// </summary>
        ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING = 14078, // 0x000036FE
        /// <summary>
        /// The supplied assembly identity is missing one or more attributes which must be present in this context.
        /// </summary>
        ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE = 14079, // 0x000036FF
        /// <summary>
        /// The supplied assembly identity has one or more attribute names that contain characters not permitted in XML names.
        /// </summary>
        ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME = 14080, // 0x00003700
        /// <summary>The referenced assembly could not be found.</summary>
        ERROR_SXS_ASSEMBLY_MISSING = 14081, // 0x00003701
        /// <summary>
        /// The activation context activation stack for the running thread of execution is corrupt.
        /// </summary>
        ERROR_SXS_CORRUPT_ACTIVATION_STACK = 14082, // 0x00003702
        /// <summary>
        /// The application isolation metadata for this process or thread has become corrupt.
        /// </summary>
        ERROR_SXS_CORRUPTION = 14083, // 0x00003703
        /// <summary>
        /// The activation context being deactivated is not the most recently activated one.
        /// </summary>
        ERROR_SXS_EARLY_DEACTIVATION = 14084, // 0x00003704
        /// <summary>
        /// The activation context being deactivated is not active for the current thread of execution.
        /// </summary>
        ERROR_SXS_INVALID_DEACTIVATION = 14085, // 0x00003705
        /// <summary>
        /// The activation context being deactivated has already been deactivated.
        /// </summary>
        ERROR_SXS_MULTIPLE_DEACTIVATION = 14086, // 0x00003706
        /// <summary>
        /// A component used by the isolation facility has requested to terminate the process.
        /// </summary>
        ERROR_SXS_PROCESS_TERMINATION_REQUESTED = 14087, // 0x00003707
        /// <summary>
        /// A kernel mode component is releasing a reference on an activation context.
        /// </summary>
        ERROR_SXS_RELEASE_ACTIVATION_CONTEXT = 14088, // 0x00003708
        /// <summary>
        /// The activation context of system default assembly could not be generated.
        /// </summary>
        ERROR_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY = 14089, // 0x00003709
        /// <summary>
        /// The value of an attribute in an identity is not within the legal range.
        /// </summary>
        ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE = 14090, // 0x0000370A
        /// <summary>
        /// The name of an attribute in an identity is not within the legal range.
        /// </summary>
        ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME = 14091, // 0x0000370B
        /// <summary>
        /// An identity contains two definitions for the same attribute.
        /// </summary>
        ERROR_SXS_IDENTITY_DUPLICATE_ATTRIBUTE = 14092, // 0x0000370C
        /// <summary>
        /// The identity string is malformed. This may be due to a trailing comma, more than two unnamed attributes, missing attribute name or missing attribute value.
        /// </summary>
        ERROR_SXS_IDENTITY_PARSE_ERROR = 14093, // 0x0000370D
        /// <summary>
        /// A string containing localized substitutable content was malformed. Either a dollar sign ($) was followed by something other than a left parenthesis or another dollar sign or an substitution's right parenthesis was not found.
        /// </summary>
        ERROR_MALFORMED_SUBSTITUTION_STRING = 14094, // 0x0000370E
        /// <summary>
        /// The public key token does not correspond to the public key specified.
        /// </summary>
        ERROR_SXS_INCORRECT_PUBLIC_KEY_TOKEN = 14095, // 0x0000370F
        /// <summary>A substitution string had no mapping.</summary>
        ERROR_UNMAPPED_SUBSTITUTION_STRING = 14096, // 0x00003710
        /// <summary>
        /// The component must be locked before making the request.
        /// </summary>
        ERROR_SXS_ASSEMBLY_NOT_LOCKED = 14097, // 0x00003711
        /// <summary>The component store has been corrupted.</summary>
        ERROR_SXS_COMPONENT_STORE_CORRUPT = 14098, // 0x00003712
        /// <summary>
        /// An advanced installer failed during setup or servicing.
        /// </summary>
        ERROR_ADVANCED_INSTALLER_FAILED = 14099, // 0x00003713
        /// <summary>
        /// The character encoding in the XML declaration did not match the encoding used in the document.
        /// </summary>
        ERROR_XML_ENCODING_MISMATCH = 14100, // 0x00003714
        /// <summary>
        /// The identities of the manifests are identical but their contents are different.
        /// </summary>
        ERROR_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT = 14101, // 0x00003715
        /// <summary>The component identities are different.</summary>
        ERROR_SXS_IDENTITIES_DIFFERENT = 14102, // 0x00003716
        /// <summary>The assembly is not a deployment.</summary>
        ERROR_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT = 14103, // 0x00003717
        /// <summary>The file is not a part of the assembly.</summary>
        ERROR_SXS_FILE_NOT_PART_OF_ASSEMBLY = 14104, // 0x00003718
        /// <summary>The size of the manifest exceeds the maximum allowed.</summary>
        ERROR_SXS_MANIFEST_TOO_BIG = 14105, // 0x00003719
        /// <summary>The setting is not registered.</summary>
        ERROR_SXS_SETTING_NOT_REGISTERED = 14106, // 0x0000371A
        /// <summary>
        /// One or more required members of the transaction are not present.
        /// </summary>
        ERROR_SXS_TRANSACTION_CLOSURE_INCOMPLETE = 14107, // 0x0000371B
        /// <summary>
        /// The SMI primitive installer failed during setup or servicing.
        /// </summary>
        ERROR_SMI_PRIMITIVE_INSTALLER_FAILED = 14108, // 0x0000371C
        /// <summary>
        /// A generic command executable returned a result that indicates failure.
        /// </summary>
        ERROR_GENERIC_COMMAND_FAILED = 14109, // 0x0000371D
        /// <summary>
        /// A component is missing file verification information in its manifest.
        /// </summary>
        ERROR_SXS_FILE_HASH_MISSING = 14110, // 0x0000371E
        /// <summary>The specified channel path is invalid.</summary>
        ERROR_EVT_INVALID_CHANNEL_PATH = 15000, // 0x00003A98
        /// <summary>The specified query is invalid.</summary>
        ERROR_EVT_INVALID_QUERY = 15001, // 0x00003A99
        /// <summary>
        /// The publisher metadata cannot be found in the resource.
        /// </summary>
        ERROR_EVT_PUBLISHER_METADATA_NOT_FOUND = 15002, // 0x00003A9A
        /// <summary>
        /// The template for an event definition cannot be found in the resource (error = %1).
        /// </summary>
        ERROR_EVT_EVENT_TEMPLATE_NOT_FOUND = 15003, // 0x00003A9B
        /// <summary>The specified publisher name is invalid.</summary>
        ERROR_EVT_INVALID_PUBLISHER_NAME = 15004, // 0x00003A9C
        /// <summary>
        /// The event data raised by the publisher is not compatible with the event template definition in the publisher's manifest.
        /// </summary>
        ERROR_EVT_INVALID_EVENT_DATA = 15005, // 0x00003A9D
        /// <summary>
        /// The specified channel could not be found. Check channel configuration.
        /// </summary>
        ERROR_EVT_CHANNEL_NOT_FOUND = 15007, // 0x00003A9F
        /// <summary>
        /// The specified xml text was not well-formed. See Extended Error for more details.
        /// </summary>
        ERROR_EVT_MALFORMED_XML_TEXT = 15008, // 0x00003AA0
        /// <summary>
        /// The caller is trying to subscribe to a direct channel which is not allowed. The events for a direct channel go directly to a logfile and cannot be subscribed to.
        /// </summary>
        ERROR_EVT_SUBSCRIPTION_TO_DIRECT_CHANNEL = 15009, // 0x00003AA1
        /// <summary>Configuration error.</summary>
        ERROR_EVT_CONFIGURATION_ERROR = 15010, // 0x00003AA2
        /// <summary>
        /// The query result is stale / invalid. This may be due to the log being cleared or rolling over after the query result was created. Users should handle this code by releasing the query result object and reissuing the query.
        /// </summary>
        ERROR_EVT_QUERY_RESULT_STALE = 15011, // 0x00003AA3
        /// <summary>Query result is currently at an invalid position.</summary>
        ERROR_EVT_QUERY_RESULT_INVALID_POSITION = 15012, // 0x00003AA4
        /// <summary>Registered MSXML doesn't support validation.</summary>
        ERROR_EVT_NON_VALIDATING_MSXML = 15013, // 0x00003AA5
        /// <summary>
        /// An expression can only be followed by a change of scope operation if it itself evaluates to a node set and is not already part of some other change of scope operation.
        /// </summary>
        ERROR_EVT_FILTER_ALREADYSCOPED = 15014, // 0x00003AA6
        /// <summary>
        /// Can't perform a step operation from a term that does not represent an element set.
        /// </summary>
        ERROR_EVT_FILTER_NOTELTSET = 15015, // 0x00003AA7
        /// <summary>
        /// Left hand side arguments to binary operators must be either attributes, nodes or variables and right hand side arguments must be constants.
        /// </summary>
        ERROR_EVT_FILTER_INVARG = 15016, // 0x00003AA8
        /// <summary>
        /// A step operation must involve either a node test or, in the case of a predicate, an algebraic expression against which to test each node in the node set identified by the preceeding node set can be evaluated.
        /// </summary>
        ERROR_EVT_FILTER_INVTEST = 15017, // 0x00003AA9
        /// <summary>This data type is currently unsupported.</summary>
        ERROR_EVT_FILTER_INVTYPE = 15018, // 0x00003AAA
        /// <summary>A syntax error occurred at position %1!d!.</summary>
        ERROR_EVT_FILTER_PARSEERR = 15019, // 0x00003AAB
        /// <summary>
        /// This operator is unsupported by this implementation of the filter.
        /// </summary>
        ERROR_EVT_FILTER_UNSUPPORTEDOP = 15020, // 0x00003AAC
        /// <summary>The token encountered was unexpected.</summary>
        ERROR_EVT_FILTER_UNEXPECTEDTOKEN = 15021, // 0x00003AAD
        /// <summary>
        /// The requested operation cannot be performed over an enabled direct channel. The channel must first be disabled before performing the requested operation.
        /// </summary>
        ERROR_EVT_INVALID_OPERATION_OVER_ENABLED_DIRECT_CHANNEL = 15022, // 0x00003AAE
        /// <summary>
        /// Channel property %1!s! contains invalid value. The value has invalid type, is outside of valid range, can't be updated or is not supported by this type of channel.
        /// </summary>
        ERROR_EVT_INVALID_CHANNEL_PROPERTY_VALUE = 15023, // 0x00003AAF
        /// <summary>
        /// Publisher property %1!s! contains invalid value. The value has invalid type, is outside of valid range, can't be updated or is not supported by this type of publisher.
        /// </summary>
        ERROR_EVT_INVALID_PUBLISHER_PROPERTY_VALUE = 15024, // 0x00003AB0
        /// <summary>The channel fails to activate.</summary>
        ERROR_EVT_CHANNEL_CANNOT_ACTIVATE = 15025, // 0x00003AB1
        /// <summary>
        /// The xpath expression exceeded supported complexity. Please symplify it or split it into two or more simple expressions.
        /// </summary>
        ERROR_EVT_FILTER_TOO_COMPLEX = 15026, // 0x00003AB2
        /// <summary>
        /// the message resource is present but the message is not found in the string/message table.
        /// </summary>
        ERROR_EVT_MESSAGE_NOT_FOUND = 15027, // 0x00003AB3
        /// <summary>
        /// The message id for the desired message could not be found.
        /// </summary>
        ERROR_EVT_MESSAGE_ID_NOT_FOUND = 15028, // 0x00003AB4
        /// <summary>
        /// The substitution string for insert index (%1) could not be found.
        /// </summary>
        ERROR_EVT_UNRESOLVED_VALUE_INSERT = 15029, // 0x00003AB5
        /// <summary>
        /// The description string for parameter reference (%1) could not be found.
        /// </summary>
        ERROR_EVT_UNRESOLVED_PARAMETER_INSERT = 15030, // 0x00003AB6
        /// <summary>The maximum number of replacements has been reached.</summary>
        ERROR_EVT_MAX_INSERTS_REACHED = 15031, // 0x00003AB7
        /// <summary>
        /// The event definition could not be found for event id (%1).
        /// </summary>
        ERROR_EVT_EVENT_DEFINITION_NOT_FOUND = 15032, // 0x00003AB8
        /// <summary>
        /// The locale specific resource for the desired message is not present.
        /// </summary>
        ERROR_EVT_MESSAGE_LOCALE_NOT_FOUND = 15033, // 0x00003AB9
        /// <summary>The resource is too old to be compatible.</summary>
        ERROR_EVT_VERSION_TOO_OLD = 15034, // 0x00003ABA
        /// <summary>The resource is too new to be compatible.</summary>
        ERROR_EVT_VERSION_TOO_NEW = 15035, // 0x00003ABB
        /// <summary>
        /// The channel at index %1!d! of the query can't be opened.
        /// </summary>
        ERROR_EVT_CANNOT_OPEN_CHANNEL_OF_QUERY = 15036, // 0x00003ABC
        /// <summary>
        /// The publisher has been disabled and its resource is not available. This usually occurs when the publisher is in the process of being uninstalled or upgraded.
        /// </summary>
        ERROR_EVT_PUBLISHER_DISABLED = 15037, // 0x00003ABD
        /// <summary>
        /// Attempted to create a numeric type that is outside of its valid range.
        /// </summary>
        ERROR_EVT_FILTER_OUT_OF_RANGE = 15038, // 0x00003ABE
        /// <summary>The subscription fails to activate.</summary>
        ERROR_EC_SUBSCRIPTION_CANNOT_ACTIVATE = 15080, // 0x00003AE8
        /// <summary>
        /// The log of the subscription is in disabled state, and can not be used to forward events to. The log must first be enabled before the subscription can be activated.
        /// </summary>
        ERROR_EC_LOG_DISABLED = 15081, // 0x00003AE9
        /// <summary>
        /// When forwarding events from local machine to itself, the query of the subscription can't contain target log of the subscription.
        /// </summary>
        ERROR_EC_CIRCULAR_FORWARDING = 15082, // 0x00003AEA
        /// <summary>
        /// The credential store that is used to save credentials is full.
        /// </summary>
        ERROR_EC_CREDSTORE_FULL = 15083, // 0x00003AEB
        /// <summary>
        /// The credential used by this subscription can't be found in credential store.
        /// </summary>
        ERROR_EC_CRED_NOT_FOUND = 15084, // 0x00003AEC
        /// <summary>No active channel is found for the query.</summary>
        ERROR_EC_NO_ACTIVE_CHANNEL = 15085, // 0x00003AED
        /// <summary>The resource loader failed to find MUI file.</summary>
        ERROR_MUI_FILE_NOT_FOUND = 15100, // 0x00003AFC
        /// <summary>
        /// The resource loader failed to load MUI file because the file fail to pass validation.
        /// </summary>
        ERROR_MUI_INVALID_FILE = 15101, // 0x00003AFD
        /// <summary>
        /// The RC Manifest is corrupted with garbage data or unsupported version or missing required item.
        /// </summary>
        ERROR_MUI_INVALID_RC_CONFIG = 15102, // 0x00003AFE
        /// <summary>The RC Manifest has invalid culture name.</summary>
        ERROR_MUI_INVALID_LOCALE_NAME = 15103, // 0x00003AFF
        /// <summary>The RC Manifest has invalid ultimatefallback name.</summary>
        ERROR_MUI_INVALID_ULTIMATEFALLBACK_NAME = 15104, // 0x00003B00
        /// <summary>
        /// The resource loader cache doesn't have loaded MUI entry.
        /// </summary>
        ERROR_MUI_FILE_NOT_LOADED = 15105, // 0x00003B01
        /// <summary>User stopped resource enumeration.</summary>
        ERROR_RESOURCE_ENUM_USER_STOP = 15106, // 0x00003B02
        /// <summary>UI language installation failed.</summary>
        ERROR_MUI_INTLSETTINGS_UILANG_NOT_INSTALLED = 15107, // 0x00003B03
        /// <summary>Locale installation failed.</summary>
        ERROR_MUI_INTLSETTINGS_INVALID_LOCALE_NAME = 15108, // 0x00003B04
        /// <summary>A resource does not have default or neutral value.</summary>
        ERROR_MRM_RUNTIME_NO_DEFAULT_OR_NEUTRAL_RESOURCE = 15110, // 0x00003B06
        /// <summary>Invalid PRI config file.</summary>
        ERROR_MRM_INVALID_PRICONFIG = 15111, // 0x00003B07
        /// <summary>Invalid file type.</summary>
        ERROR_MRM_INVALID_FILE_TYPE = 15112, // 0x00003B08
        /// <summary>Unknown qualifier.</summary>
        ERROR_MRM_UNKNOWN_QUALIFIER = 15113, // 0x00003B09
        /// <summary>Invalid qualifier value.</summary>
        ERROR_MRM_INVALID_QUALIFIER_VALUE = 15114, // 0x00003B0A
        /// <summary>No Candidate found.</summary>
        ERROR_MRM_NO_CANDIDATE = 15115, // 0x00003B0B
        /// <summary>
        /// The ResourceMap or NamedResource has an item that does not have default or neutral resource..
        /// </summary>
        ERROR_MRM_NO_MATCH_OR_DEFAULT_CANDIDATE = 15116, // 0x00003B0C
        /// <summary>Invalid ResourceCandidate type.</summary>
        ERROR_MRM_RESOURCE_TYPE_MISMATCH = 15117, // 0x00003B0D
        /// <summary>Duplicate Resource Map.</summary>
        ERROR_MRM_DUPLICATE_MAP_NAME = 15118, // 0x00003B0E
        /// <summary>Duplicate Entry.</summary>
        ERROR_MRM_DUPLICATE_ENTRY = 15119, // 0x00003B0F
        /// <summary>Invalid Resource Identifier.</summary>
        ERROR_MRM_INVALID_RESOURCE_IDENTIFIER = 15120, // 0x00003B10
        /// <summary>Filepath too long.</summary>
        ERROR_MRM_FILEPATH_TOO_LONG = 15121, // 0x00003B11
        /// <summary>Unsupported directory type.</summary>
        ERROR_MRM_UNSUPPORTED_DIRECTORY_TYPE = 15122, // 0x00003B12
        /// <summary>Invalid PRI File.</summary>
        ERROR_MRM_INVALID_PRI_FILE = 15126, // 0x00003B16
        /// <summary>NamedResource Not Found.</summary>
        ERROR_MRM_NAMED_RESOURCE_NOT_FOUND = 15127, // 0x00003B17
        /// <summary>ResourceMap Not Found.</summary>
        ERROR_MRM_MAP_NOT_FOUND = 15135, // 0x00003B1F
        /// <summary>Unsupported MRT profile type.</summary>
        ERROR_MRM_UNSUPPORTED_PROFILE_TYPE = 15136, // 0x00003B20
        /// <summary>Invalid qualifier operator.</summary>
        ERROR_MRM_INVALID_QUALIFIER_OPERATOR = 15137, // 0x00003B21
        /// <summary>
        /// Unable to determine qualifier value or qualifier value has not been set.
        /// </summary>
        ERROR_MRM_INDETERMINATE_QUALIFIER_VALUE = 15138, // 0x00003B22
        /// <summary>Automerge is enabled in the PRI file.</summary>
        ERROR_MRM_AUTOMERGE_ENABLED = 15139, // 0x00003B23
        /// <summary>Too many resources defined for package.</summary>
        ERROR_MRM_TOO_MANY_RESOURCES = 15140, // 0x00003B24
        /// <summary>
        /// The monitor returned a DDC/CI capabilities string that did not comply with the ACCESS.bus 3.0, DDC/CI 1.1 or MCCS 2 Revision 1 specification.
        /// </summary>
        ERROR_MCA_INVALID_CAPABILITIES_STRING = 15200, // 0x00003B60
        /// <summary>
        /// The monitor's VCP Version (0xDF) VCP code returned an invalid version value.
        /// </summary>
        ERROR_MCA_INVALID_VCP_VERSION = 15201, // 0x00003B61
        /// <summary>
        /// The monitor does not comply with the MCCS specification it claims to support.
        /// </summary>
        ERROR_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION = 15202, // 0x00003B62
        /// <summary>
        /// The MCCS version in a monitor's mccs_ver capability does not match the MCCS version the monitor reports when the VCP Version (0xDF) VCP code is used.
        /// </summary>
        ERROR_MCA_MCCS_VERSION_MISMATCH = 15203, // 0x00003B63
        /// <summary>
        /// The Monitor Configuration API only works with monitors that support the MCCS 1.0 specification, MCCS 2.0 specification or the MCCS 2.0 Revision 1 specification.
        /// </summary>
        ERROR_MCA_UNSUPPORTED_MCCS_VERSION = 15204, // 0x00003B64
        /// <summary>An internal Monitor Configuration API error occurred.</summary>
        ERROR_MCA_INTERNAL_ERROR = 15205, // 0x00003B65
        /// <summary>
        /// The monitor returned an invalid monitor technology type. CRT, Plasma and LCD (TFT) are examples of monitor technology types. This error implies that the monitor violated the MCCS 2.0 or MCCS 2.0 Revision 1 specification.
        /// </summary>
        ERROR_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED = 15206, // 0x00003B66
        /// <summary>
        /// The caller of SetMonitorColorTemperature specified a color temperature that the current monitor did not support. This error implies that the monitor violated the MCCS 2.0 or MCCS 2.0 Revision 1 specification.
        /// </summary>
        ERROR_MCA_UNSUPPORTED_COLOR_TEMPERATURE = 15207, // 0x00003B67
        /// <summary>
        /// The requested system device cannot be identified due to multiple indistinguishable devices potentially matching the identification criteria.
        /// </summary>
        ERROR_AMBIGUOUS_SYSTEM_DEVICE = 15250, // 0x00003B92
        /// <summary>The requested system device cannot be found.</summary>
        ERROR_SYSTEM_DEVICE_NOT_FOUND = 15299, // 0x00003BC3
        /// <summary>
        /// Hash generation for the specified hash version and hash type is not enabled on the server.
        /// </summary>
        ERROR_HASH_NOT_SUPPORTED = 15300, // 0x00003BC4
        /// <summary>
        /// The hash requested from the server is not available or no longer valid.
        /// </summary>
        ERROR_HASH_NOT_PRESENT = 15301, // 0x00003BC5
        /// <summary>
        /// The secondary interrupt controller instance that manages the specified interrupt is not registered.
        /// </summary>
        ERROR_SECONDARY_IC_PROVIDER_NOT_REGISTERED = 15321, // 0x00003BD9
        /// <summary>
        /// The information supplied by the GPIO client driver is invalid.
        /// </summary>
        ERROR_GPIO_CLIENT_INFORMATION_INVALID = 15322, // 0x00003BDA
        /// <summary>
        /// The version specified by the GPIO client driver is not supported.
        /// </summary>
        ERROR_GPIO_VERSION_NOT_SUPPORTED = 15323, // 0x00003BDB
        /// <summary>
        /// The registration packet supplied by the GPIO client driver is not valid.
        /// </summary>
        ERROR_GPIO_INVALID_REGISTRATION_PACKET = 15324, // 0x00003BDC
        /// <summary>
        /// The requested operation is not suppported for the specified handle.
        /// </summary>
        ERROR_GPIO_OPERATION_DENIED = 15325, // 0x00003BDD
        /// <summary>
        /// The requested connect mode conflicts with an existing mode on one or more of the specified pins.
        /// </summary>
        ERROR_GPIO_INCOMPATIBLE_CONNECT_MODE = 15326, // 0x00003BDE
        /// <summary>The interrupt requested to be unmasked is not masked.</summary>
        ERROR_GPIO_INTERRUPT_ALREADY_UNMASKED = 15327, // 0x00003BDF
        /// <summary>
        /// The requested run level switch cannot be completed successfully.
        /// </summary>
        ERROR_CANNOT_SWITCH_RUNLEVEL = 15400, // 0x00003C28
        /// <summary>
        /// The service has an invalid run level setting. The run level for a service must not be higher than the run level of its dependent services.
        /// </summary>
        ERROR_INVALID_RUNLEVEL_SETTING = 15401, // 0x00003C29
        /// <summary>
        /// The requested run level switch cannot be completed successfully since one or more services will not stop or restart within the specified timeout.
        /// </summary>
        ERROR_RUNLEVEL_SWITCH_TIMEOUT = 15402, // 0x00003C2A
        /// <summary>
        /// A run level switch agent did not respond within the specified timeout.
        /// </summary>
        ERROR_RUNLEVEL_SWITCH_AGENT_TIMEOUT = 15403, // 0x00003C2B
        /// <summary>A run level switch is currently in progress.</summary>
        ERROR_RUNLEVEL_SWITCH_IN_PROGRESS = 15404, // 0x00003C2C
        /// <summary>
        /// One or more services failed to start during the service startup phase of a run level switch.
        /// </summary>
        ERROR_SERVICES_FAILED_AUTOSTART = 15405, // 0x00003C2D
        /// <summary>
        /// The task stop request cannot be completed immediately since task needs more time to shutdown.
        /// </summary>
        ERROR_COM_TASK_STOP_PENDING = 15501, // 0x00003C8D
        /// <summary>Package could not be opened.</summary>
        ERROR_INSTALL_OPEN_PACKAGE_FAILED = 15600, // 0x00003CF0
        /// <summary>Package was not found.</summary>
        ERROR_INSTALL_PACKAGE_NOT_FOUND = 15601, // 0x00003CF1
        /// <summary>Package data is invalid.</summary>
        ERROR_INSTALL_INVALID_PACKAGE = 15602, // 0x00003CF2
        /// <summary>
        /// Package failed updates, dependency or conflict validation.
        /// </summary>
        ERROR_INSTALL_RESOLVE_DEPENDENCY_FAILED = 15603, // 0x00003CF3
        /// <summary>
        /// There is not enough disk space on your computer. Please free up some space and try again.
        /// </summary>
        ERROR_INSTALL_OUT_OF_DISK_SPACE = 15604, // 0x00003CF4
        /// <summary>There was a problem downloading your product.</summary>
        ERROR_INSTALL_NETWORK_FAILURE = 15605, // 0x00003CF5
        /// <summary>Package could not be registered.</summary>
        ERROR_INSTALL_REGISTRATION_FAILURE = 15606, // 0x00003CF6
        /// <summary>Package could not be unregistered.</summary>
        ERROR_INSTALL_DEREGISTRATION_FAILURE = 15607, // 0x00003CF7
        /// <summary>User cancelled the install request.</summary>
        ERROR_INSTALL_CANCEL = 15608, // 0x00003CF8
        /// <summary>Install failed. Please contact your software vendor.</summary>
        ERROR_INSTALL_FAILED = 15609, // 0x00003CF9
        /// <summary>Removal failed. Please contact your software vendor.</summary>
        ERROR_REMOVE_FAILED = 15610, // 0x00003CFA
        /// <summary>
        /// The provided package is already installed, and reinstallation of the package was blocked. Check the AppXDeployment-Server event log for details.
        /// </summary>
        ERROR_PACKAGE_ALREADY_EXISTS = 15611, // 0x00003CFB
        /// <summary>
        /// The application cannot be started. Try reinstalling the application to fix the problem.
        /// </summary>
        ERROR_NEEDS_REMEDIATION = 15612, // 0x00003CFC
        /// <summary>A Prerequisite for an install could not be satisfied.</summary>
        ERROR_INSTALL_PREREQUISITE_FAILED = 15613, // 0x00003CFD
        /// <summary>The package repository is corrupted.</summary>
        ERROR_PACKAGE_REPOSITORY_CORRUPTED = 15614, // 0x00003CFE
        /// <summary>
        /// To install this application you need either a Windows developer license or a sideloading-enabled system.
        /// </summary>
        ERROR_INSTALL_POLICY_FAILURE = 15615, // 0x00003CFF
        /// <summary>
        /// The application cannot be started because it is currently updating.
        /// </summary>
        ERROR_PACKAGE_UPDATING = 15616, // 0x00003D00
        /// <summary>
        /// The package deployment operation is blocked by policy. Please contact your system administrator.
        /// </summary>
        ERROR_DEPLOYMENT_BLOCKED_BY_POLICY = 15617, // 0x00003D01
        /// <summary>
        /// The package could not be installed because resources it modifies are currently in use.
        /// </summary>
        ERROR_PACKAGES_IN_USE = 15618, // 0x00003D02
        /// <summary>
        /// The package could not be recovered because necessary data for recovery have been corrupted.
        /// </summary>
        ERROR_RECOVERY_FILE_CORRUPT = 15619, // 0x00003D03
        /// <summary>
        /// The signature is invalid. To register in developer mode, AppxSignature.p7x and AppxBlockMap.xml must be valid or should not be present.
        /// </summary>
        ERROR_INVALID_STAGED_SIGNATURE = 15620, // 0x00003D04
        /// <summary>
        /// An error occurred while deleting the package's previously existing application data.
        /// </summary>
        ERROR_DELETING_EXISTING_APPLICATIONDATA_STORE_FAILED = 15621, // 0x00003D05
        /// <summary>
        /// The package could not be installed because a higher version of this package is already installed.
        /// </summary>
        ERROR_INSTALL_PACKAGE_DOWNGRADE = 15622, // 0x00003D06
        /// <summary>
        /// An error in a system binary was detected. Try refreshing the PC to fix the problem.
        /// </summary>
        ERROR_SYSTEM_NEEDS_REMEDIATION = 15623, // 0x00003D07
        /// <summary>
        /// A corrupted CLR NGEN binary was detected on the system.
        /// </summary>
        ERROR_APPX_INTEGRITY_FAILURE_CLR_NGEN = 15624, // 0x00003D08
        /// <summary>
        /// The operation could not be resumed because necessary data for recovery have been corrupted.
        /// </summary>
        ERROR_RESILIENCY_FILE_CORRUPT = 15625, // 0x00003D09
        /// <summary>
        /// The package could not be installed because the Windows Firewall service is not running. Enable the Windows Firewall service and try again.
        /// </summary>
        ERROR_INSTALL_FIREWALL_SERVICE_NOT_RUNNING = 15626, // 0x00003D0A
        /// <summary>The process has no package identity.</summary>
        APPMODEL_ERROR_NO_PACKAGE = 15700, // 0x00003D54
        /// <summary>The package runtime information is corrupted.</summary>
        APPMODEL_ERROR_PACKAGE_RUNTIME_CORRUPT = 15701, // 0x00003D55
        /// <summary>The package identity is corrupted.</summary>
        APPMODEL_ERROR_PACKAGE_IDENTITY_CORRUPT = 15702, // 0x00003D56
        /// <summary>The process has no application identity.</summary>
        APPMODEL_ERROR_NO_APPLICATION = 15703, // 0x00003D57
        /// <summary>Loading the state store failed.</summary>
        ERROR_STATE_LOAD_STORE_FAILED = 15800, // 0x00003DB8
        /// <summary>
        /// Retrieving the state version for the application failed.
        /// </summary>
        ERROR_STATE_GET_VERSION_FAILED = 15801, // 0x00003DB9
        /// <summary>Setting the state version for the application failed.</summary>
        ERROR_STATE_SET_VERSION_FAILED = 15802, // 0x00003DBA
        /// <summary>
        /// Resetting the structured state of the application failed.
        /// </summary>
        ERROR_STATE_STRUCTURED_RESET_FAILED = 15803, // 0x00003DBB
        /// <summary>State Manager failed to open the container.</summary>
        ERROR_STATE_OPEN_CONTAINER_FAILED = 15804, // 0x00003DBC
        /// <summary>State Manager failed to create the container.</summary>
        ERROR_STATE_CREATE_CONTAINER_FAILED = 15805, // 0x00003DBD
        /// <summary>State Manager failed to delete the container.</summary>
        ERROR_STATE_DELETE_CONTAINER_FAILED = 15806, // 0x00003DBE
        /// <summary>State Manager failed to read the setting.</summary>
        ERROR_STATE_READ_SETTING_FAILED = 15807, // 0x00003DBF
        /// <summary>State Manager failed to write the setting.</summary>
        ERROR_STATE_WRITE_SETTING_FAILED = 15808, // 0x00003DC0
        /// <summary>State Manager failed to delete the setting.</summary>
        ERROR_STATE_DELETE_SETTING_FAILED = 15809, // 0x00003DC1
        /// <summary>State Manager failed to query the setting.</summary>
        ERROR_STATE_QUERY_SETTING_FAILED = 15810, // 0x00003DC2
        /// <summary>State Manager failed to read the composite setting.</summary>
        ERROR_STATE_READ_COMPOSITE_SETTING_FAILED = 15811, // 0x00003DC3
        /// <summary>State Manager failed to write the composite setting.</summary>
        ERROR_STATE_WRITE_COMPOSITE_SETTING_FAILED = 15812, // 0x00003DC4
        /// <summary>State Manager failed to enumerate the containers.</summary>
        ERROR_STATE_ENUMERATE_CONTAINER_FAILED = 15813, // 0x00003DC5
        /// <summary>State Manager failed to enumerate the settings.</summary>
        ERROR_STATE_ENUMERATE_SETTINGS_FAILED = 15814, // 0x00003DC6
        /// <summary>
        /// The size of the state manager composite setting value has exceeded the limit.
        /// </summary>
        ERROR_STATE_COMPOSITE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED = 15815, // 0x00003DC7
        /// <summary>
        /// The size of the state manager setting value has exceeded the limit.
        /// </summary>
        ERROR_STATE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED = 15816, // 0x00003DC8
        /// <summary>
        /// The length of the state manager setting name has exceeded the limit.
        /// </summary>
        ERROR_STATE_SETTING_NAME_SIZE_LIMIT_EXCEEDED = 15817, // 0x00003DC9
        /// <summary>
        /// The length of the state manager container name has exceeded the limit.
        /// </summary>
        ERROR_STATE_CONTAINER_NAME_SIZE_LIMIT_EXCEEDED = 15818, // 0x00003DCA
        /// <summary>
        /// This API cannot be used in the context of the caller's application type.
        /// </summary>
        ERROR_API_UNAVAILABLE = 15841, // 0x00003DE1
      }
    }
  }
}
