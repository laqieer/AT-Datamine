-- このluaスクリプトは、CO_101035_0102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera002 = SetTemplate("Actor002",-140,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_001)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020002")

-- ▼直接出力
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:あっ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_01020003")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
setup_small_camera_start(RndCamera001)
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:えっと…私に用事でも…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_01020004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101035_01020006","CO_101035_01020007","CO_101035_01020008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、俺じゃなくて、その…クレアがなにか話があるみたいでさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020010")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:そうなんですか…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_01020011")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:いいえわたしから話すことなんてないわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_01020012")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
PlayActionDirect(Actor001,"to  Std_Surp")
turn_chara(Actor001,140,0.3)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あとをつけようって言い出したのはクレアだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020013")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Normal")

	--★★クレア★★:彼女の言動が気になっただけよ別に話すことがあったわけじゃない
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_01020014")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.1)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:せっかく学園で一緒に過ごすことになったんだし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020016")

	change_face(Actor001,"Smile")

	--★★ノワール★★:リリアーナと仲良くなりたいなって思ってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020017")

-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:私と仲良く、ですか………？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_01020018")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("リリアーナ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:私なんかチビで寸胴な田舎者だし仲良くなんかしたって………
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_01020019")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ダメかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020020")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:ダダダ、ダメじゃないですっ！ダメなわけないじゃないですかっ！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_01020021")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("リリアーナ", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:嬉しいですありがとう…ございます…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_01020022")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(RndCamera009)
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:じゃあ、よかったらどこか落ち着く場所で話…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020023")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:さっきの質問の答えをまだ聞いてなかったからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020025")

-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:さっきの質問？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_01020026")

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:（ぜんぜん耳に入ってなかったみたいだな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101035_01020027")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ま、まあ、いいやせっかくだし３人で散歩でも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020028")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
setup_small_camera_start(Camera002)
turn_chara(Actor001,140,0)
PlayPartVoice("リリアーナ", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:あのっ！わた、私、今日はちょっと急いでいて…<br>だから、これで、その、失礼しますっ！！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_01020030")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start()
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,{0.67,0,-4.56},1.5)
turn_chara(Actor002,-180,0.3)
wait_time(1.5)
Hide(Actor002)
change_face(Actor001,"Surprise")
wait_time(1)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:行っちゃった…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020032")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera003)
turn_chara(Actor001,150,0)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:ますます気になるわね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_01020033")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:クレアはリリアーナのなにがそんなに気になるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020035")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:最近のリリアーナは放課後になるといつもあんな感じなの
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_01020036")


	--★★ノワール★★:あんな感じって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020037")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:あなたも見たでしょう？なにかを抱えて妙に周囲を気にしながら歩いてる
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_01020038")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:リリアーナは割といつもあんな感じじゃなかったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020039")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★クレア★★:それは否定しないけど決まって学園の外へ出て行くのが気になるの
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_01020040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園の外になにかあるんだろうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020041")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:おそらくね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_01020042")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力

	--★★クレア★★:機会があったら探ってみてもいいかもしれないわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_01020043")

	PlayAction(Actor003,"to  Std_No")

	--★★クレア★★:ただ、今日は警戒されてしまっているだろうし日をあらためましょう
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_01020044")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020045")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{-0.92,0,-2.55},1.5)
turn_chara(Actor003,-180,0.5)
wait_time(1.5)
Hide(Actor003)
wait_time(1)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…あれ？なし崩し的にクレアの捜査に巻き込まれてる！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020047")

	change_face(Actor001,"Normal")

	--★★ノワール★★:まぁ、気になるのは確かだしまたリリアーナを見かけたら調べてみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01020048")

-- ▼直接出力
local trustParam = set_communication_acquired("リリアーナ_コミュランク", "リリアーナ_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
