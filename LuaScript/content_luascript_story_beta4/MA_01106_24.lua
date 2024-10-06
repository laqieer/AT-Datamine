-- このluaスクリプトは、MA_01106_24.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",-20,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000021)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor008")
	template1()
-- ▼直接出力
change_weather_cloudy(true)
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★マルディサント★★:………すっげえ、おびえててさ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240002")

	open_select_window_tag(Actor001,"Normal","MA_01106_240004","MA_01106_240005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:おびえる…？誰に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_240007")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Sad")

	--★★マルディサント★★:人間じゃねえよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240008")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:人間じゃないって、どういうこと？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_240009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:意外だな<br>キミがおびえることなんてあるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_240011")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:アタシをどう見てんだ、アンタ…
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240012")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Sad")

	--★★マルディサント★★:おびえまくりだぜ、世のなか
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240013")

	goto Block1end

::Block1end::
	change_face(Actor003,"Sad")

	--★★マルディサント★★:狂忘症にさ<br>ずっっとおびえてた
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240015")


	--★★マルディサント★★:アタシもかかっちまったら<br>誰かにあんな悲しい想いさせんのかあ、とかさ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240016")

	PlayAction(Actor003,"to  Std_Talk")

	--★★マルディサント★★:ずぅっと、安心しちゃいらんなかった
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:…アンタがなんでアタシにそんな良くすんのか<br>わかんなくって、今もだけど
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240018")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:アンタには酷いこと、いっぱい言っちまって<br>いまさら、ダチでもねえじゃん…
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240019")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Smile")

	--★★ディナタン★★:楽しかったの、すごく
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_240020")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:ゲッホゲホゲホッ！？！？<br>…は？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:マルディサントと話しているとき<br>私、なんだか私まるで…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_240022")


	--★★マルディサント★★:まるで？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240023")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:悪い子になれそうで
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_240024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Smile")

	--★★マルディサント★★:…ぷっ！<br>あはははは、ハッ！？エホエホッゲホッ！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240026")


	--★★マルディサント★★:なんだ、悪い子になりたかったのか？<br>いいのかよ、オニーサン？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01106_240029","MA_01106_240030")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:友達は選べよ、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_240032")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:兄さんだってわかってるでしょ<br>マルディサントが本当は…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_240033")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Shy")

	--★★マルディサント★★:だーっ！<br>それ以上言うな！痒くなる！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240034")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:アタシはハートフルな物語は苦手なんだ<br>叙事詩専門でね
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240035")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺もマルディサントと話しているときは<br>悪い子になったような気がしてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_240037")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★マルディサント★★:荒くれ傭兵団にいたアンタにゃ<br>悪さじゃかなわねーよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:そうだよ<br>私も本当はとっても悪い子かもよ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_240039")

	goto Block2end

::Block2end::
	change_face(Actor002,"Normal")

	--★★ディナタン★★:それに、悪い子も演じられたほうが<br>きっとわかることもあると思う
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_240041")


	--★★ディナタン★★:…ブライアンさんも、きっと
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_240042")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:あのオッサンか
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_240043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:虚勢を張って<br>嘘ついてるのがわかったから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_240044")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000021)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
