-- このluaスクリプトは、MA_01A110_29.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera004 = SetTemplate("Actor004",-204,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera005 = SetTemplate("Actor005",-151,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor007")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:頑張れよ、実行委員
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290002")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:慌ただしいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_290003")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★フィエナ★★:ガラハッドが<br>ひとりで出て行っちゃったの…！
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01A110_290004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:行先は明確にわかっているわ<br>問題は追いつけるかどうかだけ
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","MA_01A110_290005")

	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
 --PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★リリアーナ★★:ガラハッドのことだから<br>大丈夫だとは思いますが…
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01A110_290006")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:ガラハッドのことだから<br>無茶しそうで心配だな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290007")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…大変そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_290008")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:困難を極めるとはこのことだ<br>こちらでも魔女姉妹が猛威を振るっている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290009")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:だが必ず聖杯は見つけ出す<br>継承者に託さなければならないからな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:少し長旅になる<br>お前たちが復活させた学園祭、見てみたかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290011")

	open_select_window_tag(Actor001,"Normal","MA_01A110_290013","MA_01A110_290014","MA_01A110_290015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…こんなことをしてる場合なのか<br>とも思うんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_290017")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:学生に、戦いだけが人生だとは思わせたくはない<br>戦いの後に安息や楽しさがあると…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290018")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:そう信じられる寄る辺を<br>学園に作れることを願っている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:アーサーも、俺もな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:来年もやろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_290022")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★フィエナ★★:いいねっ！<br>今年のうちにカタをつけちゃおう～！
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01A110_290023")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
 --PlayPartVoice("リリアーナ", "照れ")
-- ▲直接出力
	change_face(Actor004,"Shy")

	--★★リリアーナ★★:その際は、あの、私たちもお邪魔して<br>よろしいでしょうか…？
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01A110_290024")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
 --PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エクセリア★★:コルベニックには娯楽が少ない<br>学園に来て、その重要性に気付いたわ
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","MA_01A110_290025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:もちろん、大歓迎だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_290026")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これからのために<br>すべきだと思ったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_290028")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:バルバロイを大きく消耗させたことは聞いている<br>そのおかげに俺たちが聖杯探索を進める
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290029")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:お前たちは来るべき戦いのために<br>助走をつけておけ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290030")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★エクセリア★★:最適解だと思うわ
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","MA_01A110_290031")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
 --PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★リリアーナ★★:ローマの動きは私たちも睨んでおきます…<br>どうかご存分に楽しんで…！
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01A110_290032")

	goto Block1end

::Block1end::
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
 --PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:戦いの影響が学園に及べば祭りも中止らしいな<br>となれば、いよいよ負けられない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290034")

	PlayAction(Actor005,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★フィエナ★★:聖杯より先にガラハッドを見つけなくちゃ…<br>もおおお、ごめんね、ごめんねランスロット…！
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01A110_290036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "納得")
-- ▲直接出力

	--★★ランスロット★★:気にするな、慣れている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:昔のノワールを見てるようだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A110_290038")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor007")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
