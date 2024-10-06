-- このluaスクリプトは、MA_01C111_25.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera002 = SetTemplate("Actor002",175,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad02")
change_face(Actor001,"Sad")
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor001,0,0,0,0)
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102010)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115117)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:おい、大丈夫かよ<br>今少しフラついたんじゃねえか
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C111_250003")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
PlayActionDirect(Actor001,"to Std_Loop")
turn_chara(Actor001,-50,1)
lookat_delay_weight(Actor001,0.4,0.03,0.7,0.6,1)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:え？そ、そんなことないって<br>ちょっと躓いただけ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C111_250004")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ディナタン★★:それより急がなきゃ<br>もうすぐ魔女パレードが始まるよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C111_250005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:…いや、駄目だ<br>ちょっとその辺で休んだほうがいい
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C111_250006")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
setup_small_camera_start(Camera003)
turn_lookat(Actor001,Actor003,0)
turn_lookat(Actor002,Actor003,0)
-- ▲直接出力

	--★★モルドレッド★★:ずいぶん<br>チョーシ良さそうじゃねえか
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250008")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
set_enable_auto_lookat_all(false)
set_pos(Actor003,{-4.5,0,-0.56})
change_face(Actor001,"Surprise")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:…お互いな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C111_250009")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera005)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{-2.9,0,0.6},1.5)
wait_time(1.3)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力

	--★★モルドレッド★★:家族連れじゃねえのかよ、ん？
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250010")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ディナタン★★:…兄さんは兄さんで<br>思い出づくりをしてほしいので
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C111_250011")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★モルドレッド★★:けなげだね
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★マルディサント★★:馬鹿にしてんのか
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C111_250013")

	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Normal")

	--★★モルドレッド★★:思い出を後生大事にするヤツばっかでよォ<br>そんなにイイもんかね？
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250014")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★マルディサント★★:覚えていてやるために<br>戦ってんじゃねえのかよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C111_250015")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★モルドレッド★★:どいつもこいつも<br>忘却だ過ちだとやかましい
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250016")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★モルドレッド★★:思い出が今を戦うための薪にでもなるなら<br>喜んで燃やしてやるがよォ…
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250017")


	--★★モルドレッド★★:重しになるなら<br>いっそ捨てちまったほうがいい
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ディナタン★★:…なにを、いいたいんですか
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C111_250019")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★モルドレッド★★:テメエの「察して欲しい」目線が苛立つぜ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250020")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★マルディサント★★:ナニサマだテメエ！！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C111_250022")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
turn_lookat(Actor003,Actor002,0.5)
-- ▲直接出力

	--★★モルドレッド★★:見つめ合ってウフフ、じゃねえんだよ<br>GSの繋がりに甘えてんじゃねえ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250023")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:ディーナにだって<br>言いてえことと言えねえことがあるだろうが！！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C111_250025")


	--★★マルディサント★★:なにも知らねえヤツが<br>ズカズカ偉ッそうによォッ！！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C111_250026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:テメエ<br>家族のことを信じすぎじゃねえの
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250028")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ディナタン★★:…っ！<br>信じることの、なにがいけないんですか
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C111_250029")


	--★★モルドレッド★★:信じられねえ相手とだから<br>愉しいんじゃねえのかよ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250030")

-- ▼直接出力
change_face(Actor002,"Surprise")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:………え
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C111_250031")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")

	--★★モルドレッド★★:相手が信じられねえから<br>守ってやんなきゃしょーがねえんじゃねえの
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250032")

	change_face(Actor002,"Surprise")

	--★★マルディサント★★:………
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C111_250033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")

	--★★モルドレッド★★:人生は祭りだ<br>愉しめよ
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250035")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{-6.61,0,-2.46},3)
turn_chara(Actor003,-130,1)
wait_time(0.5)
setup_small_camera_start(RndCamera002)
wait_time(1.5)
fadeout(0,0,0,1.0,1)
wait_time(1)
PlayActionDirect(Actor003,"to Std_Loop")
Hide(Actor001)
Hide(Actor002)
Camera003=setup_small_camera_resetting(Actor003,CharaPos009,CameraPos009)
set_rot(Actor003,{0,-120,0})
setup_small_camera_start(Camera003)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad01")
-- ▲直接出力

	--★★モルドレッド★★:………クラリス、どこいった
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C111_250037")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102010)
	InitializeLoad_Preload()
	load_area_scene_preload(115117)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
