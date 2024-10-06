-- このluaスクリプトは、MA_01C900_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-80,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera002 = SetTemplate("Actor002",185,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	Camera003 = SetTemplate("Actor003",251.0545,CharaPos110101_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_008)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
set_pos(Actor003,{9.29049, 0, -1.67911})
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
taijopos = {-1.112, 0, 0.49,   185}
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,-1.112, 1.50, 0.49)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115104)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ここに、いたのか<br>ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010002")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:…ごめんね、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010003")


	--★★ノワール★★:ディナタン、知ってたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010004")

-- ▼直接出力
setup_small_camera_start()
turn_lookat_position(Actor002,CharaPos004[1],CharaPos004[2],CharaPos004[3],0.5)
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.5)
set_common_look_at(Actor002,Actor001)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:私たちが兄妹じゃなかったってこと？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010005")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:私…それをあの森に<br>教えてもらった気がする
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010006")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ディナタン★★:忘れてたけど、少しずつ思い出してきた<br>アーサー様にもこのあいだ教えてもらったの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010007")


	--★★ノワール★★:…だから様子がおかしかったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010008")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:いっぱい夢を見て<br>いろんなことがわかんなくなって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010009")


	--★★ディナタン★★:どれが本当だったのか<br>なにが夢なのか
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:もしかしたら誰かの記憶なのか<br>ぜんぶわかんなくなっちゃった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010011")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:どうして言ってくれなかったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010012")


	--★★ディナタン★★:だって…だって、夢が本当だったら…<br>兄さんと兄妹じゃなくなっちゃうから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★ディナタン★★:あんな夢見ちゃいけないから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010014")


	--★★ディナタン★★:私たちあの森にずっといたよね<br>そのあと時間の流れが違うって聞いて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010016")


	--★★ディナタン★★:ああ、やっぱりそうだったんだって<br>夢じゃなかったんだって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010017")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:でも森を出たら忘れちゃって<br>兄さんは覚えてないんだよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010019")


	--★★ディナタン★★:妖精と人間は恋をしちゃいけないんだって<br>そう森に教えてもらったの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:アーサー様のお父さんと妖精のあいだに<br>生まれた私は妖精？人間？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010021")


	--★★ノワール★★:どっちでもディナタンは<br>ディナタンのままだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010022")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ディナタン★★:そうかなぁ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:ギネヴィアさんが私の歌が好きだって<br>私の歌の力は妖精の力だったんだね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010024")


	--★★ディナタン★★:それから…ねえ、兄さん<br>私たち兄妹でよかった？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C900_010026","MA_01C900_010027")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:生まれがどうとか関係ない<br>ディナタンが妹でよかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンは<br>俺の妹でなきゃダメだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010030")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:そっか、私も兄さんが兄さんでよかった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010031")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:わからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010033")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタンが妹じゃないなんて考えられない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010034")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタンは妹であってほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010035")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんな気持ちもあったけど<br>今は…わからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010036")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:私も同じだよ、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010037")

	goto Block1end

::Block1end::
	change_face(Actor002,"Sad")

	--★★ディナタン★★:兄妹だったら――<br>妖精と人間と同じだよね、そんなの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010039")

	change_face(Actor001,"Sad")

	--★★ノワール★★:どういう意味だ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_010040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…私、これからもがんばるから<br>妹として
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010041")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:がんばってアーサー様を倒そうね<br>兄さん?
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_010042")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
Appear(Actor003)
turn_lookat_position(Actor002,taijopos[1],taijopos[2],taijopos[3],0.5)
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.5)
lookat_weight(Actor001,0.8, 0.03, 0.6, 0.3)
keep_delay_ik_lookat_object(Actor001,nil,"kara",0.3)
slidemove(Actor002,taijopos[1],taijopos[2],taijopos[3],4.0 )
setup_small_camera_start(RndCamera008)
wait_time(3.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
taijopos = {-1.112, 0, 0.49,   185}
	InitializeLoad_Preload()
	load_area_scene_preload(115104)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
