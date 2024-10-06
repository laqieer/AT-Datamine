-- このluaスクリプトは、MA_01B111_14.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101160011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor003,"Surprise")

	--★★アーサー★★:「聖杯を手にしても<br>奇跡はありえないかもしれない」…
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B111_140002")

	change_face(Actor004,"Surprise")

	--★★マーリン★★:「ノワール卿は<br>誰かに継承者にさせられた」…
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B111_140003")

	change_face(Actor004,"Sad")

	--★★マーリン★★:…それを、どこで？
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B111_140004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
change_face(Actor003,"Normal")
-- ▲直接出力
-- ▼直接出力
change_face(Actor004,"Normal")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:記憶がよぎるんです<br>経験したことのない記憶が
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140005")


	--★★ノワール★★:かつて父さんが守護していた妖精ニニアンの<br>語る言葉が、悲痛な声が
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140006")


	--★★ランスロット★★:…ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ランスロット★★:それは<br>ブルーノの形見だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140009")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:父さんの、『形見』………？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140011")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:それは…過去に師匠が見た光景<br>彼が記憶の奥底に秘めていた追憶だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:俺が師匠とGSすることで<br>師匠の記憶が俺の脳裏に共有された
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140014")

	change_face(Actor004,"Normal")

	--★★マーリン★★:…GSは<br>存在同士の絆を繋ぐものです
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B111_140016")

	PlayAction(Actor004,"to  Std_Talk")

	--★★マーリン★★:双方の存在の共振により<br>互いの記憶もまた共有されることもありうる…
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B111_140018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:お前と俺のGSでも<br>同様のことが起きていく
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140019")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:聖杯や妖精の真実に近づくたびに<br>師匠の記憶が共鳴し、浸透していくことになる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140020")


	--★★ランスロット★★:これから先、お前には<br>４つの真実が明かされていく
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140021")


	--★★ランスロット★★:そのひとつ目がお前の語ったそれ<br>『聖杯の真実』──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:「お前は聖杯により<br>継承者として選ばれた」んだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140024")


	--★★ノワール★★:４つの、真実…？<br>………俺が、選ばれた…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だとすれば俺を継承者にしたのは…誰だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140028")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そいつは聖杯の使いかたを知っていたのか…！？<br>いったい…どうやって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140029")

	change_face(Actor004,"Sad")

	--★★マーリン★★:…それもまたランスロット卿の記憶共有により<br>明らかにされる…ということでよろしいですか？
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B111_140030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:………はい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B111_140032","MA_01B111_140033")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それを今まで明かさなかったのには<br>理由があるんだな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140035")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:そう…思ってくれるのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:信じると決めたんだ<br>あんたが父さんのことを話してくれたときに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140037")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Anger")

	--★★ノワール★★:また隠しごとか…！<br>どうして黙っていた、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140039")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ランスロット★★:言葉で語って理解できることでは到底なかった<br>俺がそうだった、お前も…そうだと思った
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140041")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:継承者としての重責があるなかで<br>さらに背負わせては…ならないと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140042")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:…母さんが同じ顔をしていた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140044")


	--★★ノワール★★:息を引き取る間際、理不尽な真実を隠しながら<br>それでも俺たちが進むべき道を示してくれた表情
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140045")


	--★★ノワール★★:なにか遺そうとしてくれた顔に、似ている<br>だから──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ノワール<br>俺はお前を喪いたくない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140048")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:だがこれより明かされる真実は<br>恐らく、お前を深く深く傷つけていく
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140050")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:信じがたいからこそ<br>目の当たりにしてもらいたい事実ではあるが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140051")


	--★★ランスロット★★:道を進めば進むほど<br>深みにはまっていくことになる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140052")


	--★★ランスロット★★:だが、だからこそ…一歩ずつ<br>ノワール、俺に、一歩ずつ──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140053")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:手を引かせてくれないか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:…ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140056")


	--★★ランスロット★★:継承者が聖杯を手にして起こすのは<br>まぎれもない奇跡だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140057")


	--★★ランスロット★★:望んだ平和を勝ち取れる<br>戦いのない日々がやってくる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140059")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:………俺があんたとGSを果たしたのは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140061")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ノワール★★:もう、誰も喪わないためだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140062")


	--★★ランスロット★★:俺もだ。ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140063")

	change_face(Actor001,"Normal")

	--★★ノワール★★:誰かの家族も、大切なひとも、故郷も<br>もう二度と喪われない平和を叶えられるんだな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140064")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:約束する
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140065")


	--★★ノワール★★:覚えているか、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:「世界平和を叶える聖杯を探し求め<br>その聖杯へ導く妖精を守る騎士」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140067")


	--★★ノワール★★:俺たちは円卓の騎士になると
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140068")


	--★★ランスロット★★:託された遺志と<br>継がれた命に賭けて
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:誓うか。ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_140070")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:誓うよ。ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140071")


	--★★ランスロット★★:お前の武器は、背かない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_140072")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101160011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
