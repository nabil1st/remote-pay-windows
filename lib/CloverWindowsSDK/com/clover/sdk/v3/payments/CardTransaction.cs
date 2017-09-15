/**
 * Autogenerated by Avro
 * 
 * DO NOT EDIT DIRECTLY
 */

// Copyright (C) 2016 Clover Network, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
//
// You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;

namespace com.clover.sdk.v3.payments {


public class CardTransaction {

  /// <summary>
  /// The payment with which the card transaction is associated
  /// </summary>
  public com.clover.sdk.v3.base_.Reference paymentRef { get; set; }

  /// <summary>
  /// The credit with which the card transaction is associated
  /// </summary>
  public com.clover.sdk.v3.base_.Reference creditRef { get; set; }

  public com.clover.sdk.v3.payments.CardType cardType { get; set; }

  public com.clover.sdk.v3.payments.CardEntryType entryType { get; set; }

  /// <summary>
  /// The first four digits of the card number
  /// </summary>
  public String first6 { get; set; }

  /// <summary>
  /// The last four digits of the card number
  /// </summary>
  public String last4 { get; set; }

  public com.clover.sdk.v3.payments.CardTransactionType type { get; set; }

  /// <summary>
  /// Authorization code (if successful)
  /// </summary>
  public String authCode { get; set; }

  public String referenceId { get; set; }

  public String transactionNo { get; set; }

  public com.clover.sdk.v3.payments.CardTransactionState state { get; set; }

  /// <summary>
  /// Extra info to be stored as part of gateway/card transaction
  /// </summary>
  public Dictionary<String,String> extra { get; set; }

  public Int64 begBalance { get; set; }

  public Int64 endBalance { get; set; }

  public com.clover.sdk.v3.payments.AVSResult avsResult { get; set; }

  public String cardholderName { get; set; }

  public String token { get; set; }

}

}
