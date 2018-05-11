﻿
namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helpers;

    public partial class WhenChangeConditionModel : ICloneable
    {
        #region public static properties

        #region [public] {static} (ChangeConditionModel) Empty: Gets an empty condition
        /// <summary>
        /// Gets an empty condition.
        /// </summary>
        /// <value>
        /// An empty condition.
        /// </value>
        public static WhenChangeConditionModel Empty => new WhenChangeConditionModel();
        #endregion

        #endregion

        #region private fields
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _fisrtSwapStyle;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _secondSwapStyle;
        #endregion

        #region public properties

        #region [public] (bool) IsEmpty: Gets a value indicating whether this condition is an empty condition
        /// <summary>
        /// Gets a value indicating whether this condition is an empty condition.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if is an empty condition; otherwise, <strong>false</strong>.
        /// </value>        
        public bool IsEmpty => IsDefault;
        #endregion

        #region [public] (string) FirstSwapStyle: Gets or sets
        [XmlAttribute]
        public string FirstSwapStyle
        {
            get => GetStaticBindingValue(_fisrtSwapStyle);
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage(this.GetType().Name, "FirstSwapStyle", value)));

                _fisrtSwapStyle = value;
            }
        }
        #endregion

        #region [public] (string) SecondSwapStyle: Gets or sets
        [XmlAttribute]
        public string SecondSwapStyle
        {
            get => GetStaticBindingValue(_secondSwapStyle);
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage(this.GetType().Name, "SecondSwapStyle", value)));

                _secondSwapStyle = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default

        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => base.IsDefault &&
                                          string.IsNullOrEmpty(FirstSwapStyle) &&
                                          string.IsNullOrEmpty(SecondSwapStyle);
        #endregion

        #endregion

        #region public methods

        #region [public] (ChangeConditionModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public WhenChangeConditionModel Clone()
        {
            return (WhenChangeConditionModel)MemberwiseClone();
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (object) Clone(): Creates a new object that is a copy of the current instance
        /// <inheritdoc />
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone()
        {
            return Clone();
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) Apply(int, int, FieldValueInformation, string): 
        public override string Apply(int row, int col, FieldValueInformation target, string referenceStyle)
        {
            var styleToApply = referenceStyle == "" ? FirstSwapStyle : referenceStyle;

            var rows = Service.RawData;
            var rowData = rows[row];
            var rowPreviousData = row > 0 ? rows[row - 1] : null;

            string conditionFieldValue = null;
            var fieldValue = rowData.Attribute(Field).Value;
            if (row > 0)
            {
                conditionFieldValue = rowPreviousData.Attribute(Field).Value;
            }

            if (fieldValue != conditionFieldValue && conditionFieldValue != null)
            {
                if (col == 0 && !string.IsNullOrEmpty(SecondSwapStyle))
                {
                    styleToApply = styleToApply == FirstSwapStyle
                        ? SecondSwapStyle
                        : FirstSwapStyle;
                }
                else
                {
                    if (string.IsNullOrEmpty(SecondSwapStyle))
                    {
                        styleToApply = FirstSwapStyle;
                    }
                }

                return styleToApply;
            }

            if (!string.IsNullOrEmpty(SecondSwapStyle))
            {
                return styleToApply;
            }

            if (conditionFieldValue == null)
            {
                return FirstSwapStyle;
            }

            return row.IsOdd()
                ? $"{target.Style.Name}_Alternate"
                : target.Style.Name ?? StyleModel.NameOfDefaultStyle;
        }
        #endregion

        #endregion
    }
}