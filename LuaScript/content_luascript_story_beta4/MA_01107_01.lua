-- このluaスクリプトは、MA_01107_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113021_01","113021_01_h")
Include("content_adv_advsmall_113021_01","Template113021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-10,CharaPos113021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos113021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_007)
	InitializeTemplateRandomCamera113021_01()
	InitializeTemplate113021_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_camera_nearclip(Camera001,1)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
CameraEX = set_camera({-0.495,1.162,3.958,-1.852,32.797,0,22})
set_camera_nearclip(CameraEX,1.5)
set_pos(Actor002, {0.951, 0, 6.252})
set_rot(Actor002, {0, -156.322,0})
Camera002 = manager.RegisterExclusiveCamera(CameraEX, Actor002)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113021)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101050","001","101050001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:モルガン救出のためカーライル城に乗りこんだ<br>ノワールたちは魔女との戦いで苦戦を強いられる
	Talk(Actor003,"telop","narration","N","MA_01107_021001")


	--★★テロップ★★:そんな中、ディナタンとマルディサントが<br><ruby=ゲシュタルト・シフト>ＧＳ</ruby>を果たし、新たな力を得る
	Talk(Actor003,"telop","narration","N","MA_01107_021002")


	--★★テロップ★★:遠征から帰還したばかりの円卓の騎士の力もあり<br>魔女を退けることに成功する
	Talk(Actor003,"telop","narration","N","MA_01107_021004")


	--★★テロップ★★:こうしてモルガンは無事、救出され<br>捕らわれたブライアンはログレスの捕虜となった
	Talk(Actor003,"telop","narration","N","MA_01107_021005")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力

	--★★ディナタン★★:「行くな」って言われたの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01107_010003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")

	--★★ディナタン★★:だから来ちゃった
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01107_010004")


	--★★ブライアン将軍★★:誰に止められたんだよ
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01107_010005")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ディナタン★★:悪友？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01107_010006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ブライアン将軍★★:良い友人じゃねえか
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01107_010008")

	change_face(Actor002,"Normal")

	--★★ブライアン将軍★★:要らねえ温情で敵に甘いヤツよか<br>よっぽどまともで人間デキてる
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01107_010009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ディナタン★★:憎まれ口はやめて
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01107_010010")

	change_face(Actor002,"Anger")

	--★★ブライアン将軍★★:憎まれて当然だ
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01107_010011")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_No")
-- ▲直接出力

	--★★ディナタン★★:バルバロイも魔女もカレドニアもどうやったって憎らしいよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01107_010012")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:だけど、どうしても、どうしたところで生きててくれて良かったって思うの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01107_010013")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ディナタン★★:8年、一緒に暮らしてくれたのに感じるものがないわけないでしょ？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01107_010014")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力

	--★★ディナタン★★:何度避けられてもどれだけ許されないことをした人でも
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01107_010015")


	--★★ディナタン★★:会いたくなるよずっとそうだったんだから
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01107_010016")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ディナタン★★:これって<br>そんなに悪いこと？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01107_010017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ブライアン将軍★★:…弁が立つようになった<br>道徳的だがありがた迷惑だ
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01107_010018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ディナタン★★:わかってる<br>余計なお世話だとしても
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01107_010019")


	--★★ブライアン将軍★★:もっと…聞き分けの良いヤツだと思ったが
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01107_010020")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ディナタン★★:反抗期なんです。私
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01107_010021")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_animationcontroller(Actor002, "Chr_014_01_StdController", "to Std_Loop")
Camera002 = setup_small_camera_resetting(Actor002,CharaPos007,CameraPos007)
Hide(Actor001)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
reserve_eyesync(Actor002,"Close")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Pain")

	--★★ブライアン将軍★★:ゲホッ！<br>ゲホッ！
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01107_010023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
force_eyesync(Actor002,"Auto")
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ブライアン将軍★★:ハァ、ハァ…
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01107_010024")

	change_face(Actor002,"Sad")

	--★★ブライアン将軍★★:………テメエと似て──
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01107_010025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
force_eyesync(Actor002,"Close")
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力

	--★★ブライアン将軍★★:聞き分けねえな、本当に
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01107_010026")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(113021)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101050","001","101050001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName113021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
