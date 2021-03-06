﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.EditAndContinue
{
    // TODO (tomat): cleanup

    internal enum RudeEditKind : ushort
    {
        // TELEMETRY: DO NOT MODIFY ANY ENUM VALUES BELOW THIS POINT.
        // IT WILL BREAK OUR SQM VARIABLE MAPPINGS.
        None = 0,

        ActiveStatementUpdate = 1,
        ActiveStatementLambdaRemoved = 2,

        Update = 3,
        ModifiersUpdate = 4,
        HandlesClauseUpdate = 5,
        ImplementsClauseUpdate = 6,
        VarianceUpdate = 7,
        FieldKindUpdate = 8,
        TypeUpdate = 9,
        ConstraintKindUpdate = 10,
        InitializerUpdate = 11,
        FixedSizeFieldUpdate = 12,
        EnumUnderlyingTypeUpdate = 13,
        BaseTypeOrInterfaceUpdate = 14,
        TypeKindUpdate = 15,
        AccessorKindUpdate = 16,
        MethodKindUpdate = 17,
        DeclareLibraryUpdate = 18,
        DeclareAliasUpdate = 19,
        Renamed = 20,
        Insert = 21,
        //// InsertNonPrivate = 22,
        InsertVirtual = 23,
        InsertOverridable = 24,
        InsertExtern = 25,
        InsertOperator = 26,
        //// InsertNonPublicConstructor = 27,
        InsertGenericMethod = 28,
        InsertDllImport = 29,
        InsertIntoStruct = 30,
        InsertIntoClassWithLayout = 31,
        Move = 32,
        Delete = 33,
        MethodBodyAdd = 34,
        MethodBodyDelete = 35,
        GenericMethodUpdate = 36,
        GenericMethodTriviaUpdate = 37,
        GenericTypeUpdate = 38,
        GenericTypeTriviaUpdate = 39,
        GenericTypeInitializerUpdate = 40,
        PartialTypeInitializerUpdate = 41,
        AsyncMethodUpdate = 42,
        AsyncMethodTriviaUpdate = 43,
        StackAllocUpdate = 44,

        ExperimentalFeaturesEnabled = 45,

        AwaitStatementUpdate = 46,
        ChangingConstructorVisibility = 47,

        // TELEMETRY: DO NOT MODIFY ANY ENUM VALUES ABOVE THIS POINT.
        // IT WILL BREAK OUR SQM VARIABLE MAPPINGS.

        // Values below here are not mapped by sqm:
        STMT_MID_DELETE = 0x100,
        STMT_NON_LEAF_DELETE,
        STMT_CTOR_CALL,
        STMT_FIELD_INIT,
        STMT_DELETE,
        STMT_DELETE_REMAP,
        STMT_READONLY,
        RUDE_EDIT_INSERT_AROUND,
        RUDE_EDIT_DELETE_AROUND,
        RUDE_NO_ACTIVE_STMT,
        RUDE_ACTIVE_STMT_DELETED,
        RUDE_EDIT_AROUND_ACTIVE_STMT,
        EXC_HANDLER_ERROR,
        EXC_FINALLY_ERROR,
        EXC_CATCH_ERROR,
        RUDE_EDIT_NON_USER_STMT,

        // anonymous types, iterators, lambdas, queries, dynamic, nopia
        RUDE_EDIT_ANON_METHOD,
        RUDE_EDIT_YIELD, // VB only
        RUDE_EDIT_FIELD_ANON_METH,
        RUDE_EDIT_DYNAMIC_INVOCATION,
        RUDE_EDIT_NOPIA_USAGE,
        FIELD_WITH_ANON_METHOD,
        RUDE_EDIT_LAMBDA_EXPRESSION,
        RUDE_EDIT_QUERY_EXPRESSION,
        RUDE_EDIT_ANONYMOUS_TYPE,
        FIELD_WITH_LAMBDA,
        FIELD_WITH_QUERY,
        RUDE_EDIT_FIELD_LAMBDA,
        RUDE_EDIT_FIELD_QUERY,
        FIELD_WITH_ANON_TYPE,
        RUDE_EDIT_FIELD_ANON_TYPE,
        RUDE_EDIT_MODIFY_ANON_METHOD,
        RUDE_EDIT_ADD_ANON_METHOD,
        RUDE_EDIT_DELETE_ANON_METHOD,
        RUDE_EDIT_MOVE_ANON_METHOD,
        RUDE_EDIT_LOCAL_USED_IN_ANON_METHOD,
        RUDE_EDIT_MODIFY_LAMBDA_EXPRESSION,
        RUDE_EDIT_ADD_LAMBDA_EXPRESSION,
        RUDE_EDIT_DELETE_LAMBDA_EXPRESSION,
        RUDE_EDIT_MOVE_LAMBDA_EXPRESSION,
        RUDE_EDIT_LOCAL_USED_IN_LAMBDA_EXPRESSION,
        RUDE_EDIT_MODIFY_QUERY_EXPRESSION,
        RUDE_EDIT_ADD_QUERY_EXPRESSION,
        RUDE_EDIT_DELETE_QUERY_EXPRESSION,
        RUDE_EDIT_MOVE_QUERY_EXPRESSION,
        RUDE_EDIT_LOCAL_USED_IN_QUERY_EXPRESSION,
        RUDE_EDIT_MODIFY_ANONYMOUS_TYPE,
        RUDE_EDIT_ADD_ANONYMOUS_TYPE,
        RUDE_EDIT_DELETE_ANONYMOUS_TYPE,
        RUDE_EDIT_MOVE_ANONYMOUS_TYPE,
        RUDE_EDIT_ADD_HANDLES_CLAUSE,
        RUDE_EDIT_ADD_NEW_FILE,
    }
}
