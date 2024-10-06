-- このluaスクリプトは、EA_006_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor002",nil,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	Camera002 = SetTemplate("Actor003",nil,CharaPos110122_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_006)
	Camera003 = SetTemplate("Actor004",50,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- 黒背景の表示
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:数日後
	Talk(Actor001,"","simple","N","EA_006_0210003")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(1.5)
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガレス★★:ふう～…<br>今日も円卓のお仕事がんばったな～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210004")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0008")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:働いた後はお腹が減るな！<br>もういっくらでも食べられるぞ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_006_0210005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101032_sp_0003_3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:リオネス…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","EA_006_0210008","EA_006_0210009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0036")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:リオネス、ありがと～♪<br>一緒に頑張ってくれて
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210012")

-- ▼直接出力
PlayPartVoiceDirect("リオネス","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_006_0210013")

	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Smile")

	--★★リオネス★★:そしてキラーズである以前に<br>あたしはガレスの<ruby=ベストフレンド>親友</ruby>だからな！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_006_0210014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0037")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210018")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Surprise")

	--★★リオネス★★:ワガママ？そんなのに付き合った覚えはないぞ
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_006_0210019")

-- ▼直接出力
PlayPartVoiceDirect("リオネス","0011")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:だって、ガレスがしたいことが<br>あたしのしたいことだからな！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_006_0210020")

	goto Block1end

::Block1end::
	change_face(Actor002,"Smile")

	--★★ガレス★★:リオネス…！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210022")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0012")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:一緒に見返してやろう！<br>円卓の騎士のみんなを
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_006_0210023")

	change_face(Actor003,"Anger")

	--★★リオネス★★:そのためにも…<br>とにかく今は、お腹いっぱいにしたい！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_006_0210024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:ガレスが作ったご飯をいっぱい食べたら<br>円卓の騎士もびっくりの働きができそうだ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_006_0210025")

-- ▼直接出力
PlayPartVoiceDirect("ガレス","0011")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガレス★★:ふふふ。そう言うと思って<br>コック長に言って厨房を借りたんだ～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210026")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ガレス★★:美味しいご飯をたっくさん作るな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210027")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0026")
-- ▲直接出力

	--★★リオネス★★:やった～！肉！肉！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_006_0210028")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
wait_time(0.5)
hide_image(BLACK_WHITE_TIME)
wait_time(1.5)
character_in_move_walk_offset(Actor004,CharaPos004,-2.5,0,-0.25,2.0)
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,40,0.5)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★ランスロット★★:ガレス
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210030")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
voice_play("VO_101032_sp_0006_1")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0007")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ランスロット★★:用というか…――<br>いや、その前にこの臭いは…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210032")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor004,Actor003,"J_Head",1)
wait_time(1.5)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0021")
-- ▲直接出力

	--★★ランスロット★★:…リオネス、それはなんだ…？
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210034")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0038")
-- ▲直接出力

	--★★リオネス★★:ステーキ串！ガーリックソースたっぷり！<br>食べるか？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_006_0210035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0014")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ランスロット★★:い、いや、結構だ。それよりガレス<br>バイブス学の課題が未提出になっているが…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210036")

	change_face(Actor002,"Surprise")

	--★★ガレス★★:………あ～！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210037")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0025")
-- ▲直接出力

	--★★ランスロット★★:その顔は忘れていたな
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210038")

-- ▼直接出力
PlayPartVoiceDirect("ガレス","0014")
-- ▲直接出力

	--★★ガレス★★:きれいサッパリ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210039")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0034")
-- ▲直接出力

	--★★ランスロット★★:…円卓の騎士は生徒の手本であるべきだ<br>学業を疎かにするのは感心しない
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210040")


	--★★ランスロット★★:なにより、お前は円卓の騎士である以前に<br>キャメロット学園の生徒だ。それを忘れるな
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:たとえ見習いであっても…<br>いや――見習いだからこそ、な
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210042")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガレス★★:はい…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210044")

-- ▼直接出力
setup_small_camera_end(Camera001)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0007")
-- ▲直接出力

	--★★ランスロット★★:…お前が円卓の任務を頑張っていることは<br>もちろん知っている
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ランスロット★★:おかげで他の者が遠方での任務に<br>専念することができ、感謝もしている
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210046")

-- ▼直接出力
voice_play("VO_101032_sp_0006_3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:ランスロット…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210047")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0034")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ランスロット★★:だが…少し頑張り過ぎているようにも見える<br>無理をしていないか、と
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210048")

	change_face(Actor002,"Sad")

	--★★ガレス★★:無理なんて――…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210049")


	--★★ランスロット★★:急いで証を立てようとしなくてもいい
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210050")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0008")
-- ▲直接出力

	--★★ランスロット★★:誰が何と言おうと、王が認めたのなら<br>お前は立派な円卓の騎士だ
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210051")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガレス★★:…うん。わかってる<br>わかってるんだ。でも――
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210052")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0034")
-- ▲直接出力

	--★★ランスロット★★:…ガウェインに反対されたことが<br>そんなに引っかかるのか？
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_006_0210053")

-- ▼直接出力
CloseTalkWindow()
PlayAction(Actor002,"to  Std_Worry")
setup_small_camera_start(Camera001)
wait_time(1.5)
-- ▲直接出力

	--★★ガレス★★:…引っかかりまくりだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210055")

-- ▼直接出力
voice_play("VO_101032_sp_0005_3")
-- ▲直接出力

	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210056")


	--★★ガレス★★:わたしが近くに行こうとしたら<br>急に厳しくなるなんて…勝手だ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0210057")

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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
