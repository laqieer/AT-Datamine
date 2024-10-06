-- このluaスクリプトは、MA_01106_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_009)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
DontChangeRandomCamera(true)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ディナタン★★:花を飾りながら<br>歌ってくれてたよね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020002")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:母さんみたいにうまくはできないけど<br>どうかな…兄さん？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020003")

	open_select_window_tag(Actor002,"Normal","MA_01106_020005","MA_01106_020006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ノワール★★:上手だよ<br>母さんを思い出す
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01106_020008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ディナタン★★:よかった。最高の褒めコトバ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020009")

	change_face(Actor001,"Smile")

	--★★ディナタン★★:兄さんに褒めてもらえるのが<br>一番嬉しいな
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ノワール★★:練習なら付き合うよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01106_020012")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:…それって私が音痴だってこと？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ノワール★★:ち、違う違う！<br>もっと上手になれるかも、ってことだよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01106_020014")

	goto Block1end

::Block1end::
	change_face(Actor002,"Laugh")

	--★★ノワール★★:友達と歌ったりはするのか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01106_020016")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:歌わないよ。恥ずかしいもん<br>家族の前だけ、限定、リミテッドエディション
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020017")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:ブライアンさんに言われたことがあるんだけど<br>傷が痛くなくなる…気がするんだって
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:そんなことあるかな？とも思ったんだけどね<br>私…覚えてるんだ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020020")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:母さんが歌ってくれたら…怖いことがあっても<br>うとうとしちゃう兄さんの寝顔
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020021")


	--★★ディナタン★★:だから兄さんには<br>私がいっぱい歌ってあげる
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020023")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:傷、治してあげたいんだ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020024")

	open_cutin(1,1)
	on_cutin(1,Actor003,"Normal")

	--★★マルディサント★★:やってるゥ？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","N","MA_01106_020026")

-- ▼直接出力
Appear(Actor003)
turn_chara(Actor001,207.832,0.5)
lookat_delay_weight(Actor001,1, 0.03, 0.7, 0.5,1)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
-- ▲直接出力
	close_cutin()
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:またサボリ？<br>マルディサント
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020028")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:へへ、ベッドもーらい
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020029")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
hide_image(BLACK_WHITE_TIME)
turn_chara(Actor001,145,0.5)
setup_huton_110141_02()
Camera003 = setup_small_camera_resetting(Actor003,CharaPos110141_02_001,CameraPos001)
set_animationcontroller(Actor003, "Chr_507_01_SleepController", "to Std_Loop")
Camera002 = setup_small_camera_resetting(Actor002,CharaPos110141_02_006,CameraPos006)
set_animationcontroller(Actor002, "Chr_002_01_StdController", "to Std_Loop")
DontCameraOffset(Actor003)
DontChangeRandomCamera(false)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
lookat_delay_weight(Actor001,0.4, 0.03, 0.7, 0.5,1)
setup_small_camera_start()
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ディナタン★★:もお…<br>悪い子の見本だよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020031")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:本年の五月女王は<br>良い子ちゃんですねえ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020032")

	change_face(Actor001,"Surprise")

	--★★ディナタン★★:や、やめてよおっ、図書院俳優…！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020034")

	change_face(Actor003,"Anger")

	--★★マルディサント★★:おぉまえ、マジか！言うな！マジで言うな！<br>ヒミツっつったろ！？ざけんなよマジでえ！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:ふふふ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020036")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:図書院俳優？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01106_020037")

-- ▼直接出力
setup_small_camera_start(Camera003)
Appear(Actor004)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Shy")

	--★★マルディサント★★:なんでもねえよ！二度と言うな！忘れろ！<br>舌噛んでしばらく喋れなくなれ！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020038")

-- ▼直接出力
 --setup_small_camera_start(Camera004)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor004)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★モルガン★★:俳優さんは声が大きくてよろしい
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01106_020040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:モルガンせんせ…！<br>せんせは誰にも言ってないっすよねえ…？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020041")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★モルガン★★:秘密は胸に秘めてこそよ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01106_020042")

	change_face(Actor003,"Smile")

	--★★マルディサント★★:モルガンせんせの至言！<br>やっぱせんせスキだわ～
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:モルガン先生にバレてるのはいいの？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020044")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Laugh")

	--★★マルディサント★★:…モルガンせんせだから、いいんだよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020045")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★モルガン★★:マルディサントはね～<br>グラストンベリーの近くの村の生まれなの
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01106_020046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ノワール★★:グラストンベリー…<br>モルガン先生の別荘がある…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01106_020047")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:親父とお袋が病気で死んでから<br>妹とふたり暮らししててさ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020048")


	--★★マルディサント★★:そんなひもじい現実から<br>目を逸らす一番のクスリって知ってるか？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020049")


	--★★ディナタン★★:…え？そんなの、あるの…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:『ごっこ遊び』だよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020051")


	--★★マルディサント★★:お腹空いてないごっこ、楽しい生活ごっこ<br>格好良い物語の登場人物ごっこ、お芝居ごっこ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020052")


	--★★モルガン★★:…グラストンベリーの道端でね、見たのよ<br>小さな青空劇場。妹さんと楽しそうにしてて──
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01106_020053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★モルガン★★:だからお誘いしたの<br>「私の別荘でもっと見せてくれません？」って
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01106_020054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MA_01106_020055","MA_01106_020056")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ノワール★★:優しいんだな、モルガン先生
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01106_020058")

	change_face(Actor004,"Smile")

	--★★モルガン★★:こんなに可愛い劇団を別荘に置けるなら<br>お姉さん大歓迎だもの～
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01106_020059")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★マルディサント★★:そのあと、別荘に住み込みの手伝いを<br>させてくれるようになったんだ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020060")

	change_face(Actor003,"Smile")

	--★★マルディサント★★:アタシと妹のために<br>キレーな部屋まで用意してくれてな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020061")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ノワール★★:優しいんだな、マルディサント
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01106_020063")

	change_face(Actor003,"Surprise")

	--★★マルディサント★★:ああ<br>すっげ優しいひとだよ…ってアタシ！？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020064")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Shy")

	--★★マルディサント★★:この話の流れだったら<br>モルガンせんせのことだろ、フツー！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020065")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ディナタン★★:私もマルディサントは<br>優しいと思うな
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020066")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:口は悪いし、授業もサボってばっかりだけど<br>意外に気配りできるし。意外に
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020067")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★マルディサント★★:…ホめてねーだろ、それ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020068")

	goto Block2end

::Block2end::
	change_face(Actor001,"Normal")

	--★★ディナタン★★:…マルディサントの妹さんにも<br>会ってみたいな
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_020070")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:会えるぜ、いつか
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020071")

	change_face(Actor002,"Laugh")

	--★★ノワール★★:今はどこに？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01106_020072")


	--★★マルディサント★★:リンゴの木の下
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020074")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor002,"Surprise")
	on_cutin(2,Actor001,"Surprise")
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	close_cutin()
	change_face(Actor003,"Sad")

	--★★マルディサント★★:いや、親父とお袋が待ってる場所かな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020076")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:ここで寝てりゃ<br>いつかは会いに行ける
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_020078")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
