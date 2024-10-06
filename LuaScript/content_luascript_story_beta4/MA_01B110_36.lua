-- このluaスクリプトは、MA_01B110_36.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-110,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera004 = SetTemplate("Actor004",-75,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
Hide(Actor004)
Hide(Actor005)
Hide(Actor003)
set_pos(Actor003,CharaPos110021_01_102)
set_pos(Actor004,CharaPos110021_01_106)
set_pos(Actor005,CharaPos110021_01_107)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
keep_ik_lookat(Actor005,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_2DOnly("101026","001","101026001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:悲しいお報せと嬉しいお報せがあるの<br>どっちが聞きたい？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360002")

	open_select_window_tag(Actor001,"Normal","MA_01B110_360003","MA_01B110_360004")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:悲しいお報せから聞こうか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_360006")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:心の準備はいい？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:こ、怖がらせるなよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_360008")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:嬉しいお報せから聞こうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_360010")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ノワールあなた<br>好物から先に食べるタイプ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360011")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:もったいぶるなよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_360012")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:学園祭を決行してしまったの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360014")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:聖杯探索班が出かけているあいだに<br>盛大にね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360015")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Anger")
	change_face(Actor006,"Anger")

	--★★パーシヴァル2D★★:やっぱりなー！！おかしいと思ったんだ！！<br>なんか学園全体が祭りのあと感あるなと思った！
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","N","MA_01B110_360017")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
change_face(Actor001,"Surprise")
change_face(Actor002,"Surprise")
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor002,130,0.5)
lookat_weight(Actor002,0.7,0.03,0.7,0)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.7)
set_common_look_at(Actor001,Actor003)
change_face(Actor003,"Anger")
IN_RUN(Actor003,CharaPos110021_01_002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor002,false)
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力

	--★★パーシヴァル★★:日程は未定という噂だったじゃないか！<br>行えるかどうかすらわからないとかで！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_360018")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか状況が変わったとか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_360019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:変わった子がいたのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:「GSをした騎士たちは<br>思い出の数だけ強くなれる」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360022")


	--★★ギネヴィア★★:「だからこそ、この学園での思い出が欲しい<br>これからの戦いに向けて」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360024")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★ギネヴィア★★:来る戦いを前に、ただ待つことしかできず<br>不安に思う生徒たちを想った提言をしてくれて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360025")


	--★★ギネヴィア★★:ロンディニウムを追われた市民たちのためにも<br>安息と、悲劇から目を逸らすひとときを…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:アーサーも学長として<br>跳ね除ける理由はなかったみたいね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360027")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★パーシヴァル★★:くっ…そんなこと言われたら<br>こっちもいろいろ言いづらいじゃないか…！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_360028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★パーシヴァル★★:でも演劇をやるという話だっただろう！？<br>主演のボクがいないのにどうやったというんだ
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_360029")

-- ▼直接出力
setup_small_camera_start(Camera002)
PlayActionDirect(Actor002,"to  Std_Talk")
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1)
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力

	--★★ギネヴィア★★:主演があなたではなかったから<br>なんの問題もなく上演できましたヨカッタネ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360030")

-- ▼直接出力
Appear(Actor004)
Appear(Actor005)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor003,"Anger")

	--★★パーシヴァル★★:ギー！！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","N","MA_01B110_360031")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
IN_WALK_2P(Actor004,CharaPos110021_01_006,Actor005,CharaPos110021_01_007)
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
set_rot(Actor001,{0,-160,0})
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",2)
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★エレイン★★:ギネヴィア様<br>昼食…ごいっしょにいかがですか？
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01B110_360033")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(false)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:すぐ行くわ、エレイン<br>先に食べててちょうだい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360034")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:そうするつもりでしたので
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01B110_360036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:あっ！わたしのぶんを頼むなら<br>１人前でいいからね！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360037")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定3")
-- ▲直接出力

	--★★エレイン★★:わかりました
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01B110_360038")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor004)
Hide(Actor005)
set_rot(Actor001,{0,-110,0})
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,Actor001)
set_common_look_at(Actor003,Actor002)
setup_small_camera_start(RndCamera001)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to Bow")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:提言してくれたウワサの主演女優でした
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360040")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★パーシヴァル★★:ぐうの音が出ないほどの美しさだな！<br>ルックスだけの話ではなく！！納得したよ！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_360041")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_No")
turn_chara(Actor002,200,0.5)
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力

	--★★ギネヴィア★★:まったく<br>悲しいお報せになってごめんなさいね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360042")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor002,130,0.5)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:あなたたちも長旅で疲れたでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360043")


	--★★ギネヴィア★★:次の聖杯探索に出るまでは<br>短いあいだかもしれないけどゆっくり休むのよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360044")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Surp")
turn_chara(Actor001,-120,0.3)
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あれっ…『嬉しいお報せ』っていうのは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_360045")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:わかんないの、ノワールぅ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360046")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:我らローマ対策班がバルバロイを押し留め<br>聖杯探索班が魔女を叩きのめしてくれたおかげで
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Finger")
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:お祭りができたってことよ<br>うれしいでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B110_360049")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_2DOnly_Preload("101026","001","101026001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
