-- このluaスクリプトは、MA_01104_107.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
Include("content_adv_advsmall_112041_01","112041_01_h")
Include("content_adv_advsmall_112041_01","Template112041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_002)
	Camera002 = SetTemplate("Actor002",34.9,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera003 = SetTemplate("Actor003",-71,CharaPos112041_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_005)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{3.44,0,2.44})
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor003, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
-- ▼直接出力
  prop_001    = load_particle("content_prop_10104007", "10104007_PropModel", true, true)
    set_pos(prop_001,{2.237,1.208,2.283})
    set_rot(prop_001,{0,0,0})
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_003)
	Camera003 = SetTemplate("Actor003",-264.4,CharaPos112041_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_004)
	InitializeTemplateRandomCamera112041_01()
	InitializeTemplate112041_01()
-- ▼直接出力
  prop_002    = load_particle("content_prop_10104014", "10104014_PropModel", true, true)
    set_pos(prop_002,{-0.82,0.81,2.283})
    set_rot(prop_002,{0,-2.94,0})
-- ▲直接出力
-- ▼直接出力
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor003, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116047)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ウレリー★★:マスター、おあいそ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070003")

-- ▼直接出力
CloseTalkWindow()
set_common_look_at(Actor002,Actor003)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,87.2,0.11)
wait_time(0.11)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ウレリー？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070004")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Serious")

	--★★ウレリー★★:マスター、おあいそ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:待って待って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070008")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.8)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-45.8,0.23)
wait_time(0.23)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
shake_camera(RndCamera002, 0.52, 0.66)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Sad")

	--★★ウレリー★★:ばらす気だあ！！<br>ひとりさびしいヤツだってええ！！
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070010")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:い、いいじゃないか<br>ひとりの時間を満喫するのはむしろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070011")

-- ▼直接出力
shake_camera(RndCamera002, 0.52, 0.66)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to  Std_Angry")
wait_time(0.32)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ウレリー★★:おつまみがね！カラダに悪そうでおいしいから！<br>ちょっとつまんだりしてるんだよ！ときどきね！
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:オススメは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070014")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to  Std_Sad02")
wait_time(2.2)
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★ウレリー★★:………おしえてあげる
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070016")

-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
template2()

off_active(prop_001)
on_active(prop_002)
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, false)
setup_small_camera_start(RndCamera001)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(1.9)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ウレリー★★:円卓の騎士やりながら学生やって<br>さらに憲兵団までやるなんて
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:見習ったんだよ。ウレリーのこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ウレリー★★:ふふふ。忙しくなるだろうし<br>ワタシの学園案内も終わりだね
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ウレリー★★:ワタシが、その…絡みに行かなくなったら<br>…ちょっとは休めそう、かな？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070021")

	open_select_window_tag(Actor001,"Normal","MA_01104_1070023","MA_01104_1070024","MA_01104_1070025")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:まずはキャメリアードを取り戻す<br>その力になりたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070027")

	change_face(Actor002,"Normal")

	--★★ウレリー★★:ギネヴィア王妃殿下の故郷だよね
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:そもそもこの学園に来られたのも<br>彼女がいてくれたからだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070029")

	change_face(Actor001,"Serious")

	--★★ノワール★★:その恩は返したい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070030")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンの居場所を作りたいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070032")

	change_face(Actor002,"Sad")

	--★★ウレリー★★:カレドニアには帰れないだろうし<br>…そうだよね
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070033")

	change_face(Actor001,"Sad")

	--★★ノワール★★:傭兵団は跡形もない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:だったらせめて<br>安心して学園にいられるようにしてあげたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070035")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロットを追って<br>ここまで来たんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070037")

	change_face(Actor002,"Surprise")

	--★★ウレリー★★:ふたりは幼馴染なんだっけ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070038")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロットに<br>聞きたいことがあるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070039")

	change_face(Actor001,"Serious")

	--★★ノワール★★:この学園に入れば『本当』がわかると言っていた<br>打ち明けてくれるまで追いかける
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070040")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera003)
CloseTalkWindow()
wait_time(0.52)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ウレリー★★:ねえ<br>戦うのってさ、怖くない？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070042")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:誰かがいなくなるほうが怖いんだ<br>だから戦ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070043")

	change_face(Actor002,"Serious")

	--★★ウレリー★★:………たのもしいよ、ノワールくん
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070044")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor002, false)
lookoj=create_object("kara")
set_pos_object(lookoj,0.5,0,2)
keep_delay_ik_lookat_object(Actor002,lookoj,"kara",1.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ウレリー★★:ワタシね…お父さんをバルバロイに食べられて<br>顔も覚えていないんだ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070046")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ウレリー★★:忘れちゃったんだ<br>みんな、お父さんのこと
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070048")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★ウレリー★★:ワタシ、ぞっとしちゃって
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070050")


	--★★ウレリー★★:日記とか見て、父さんを思い出そうとしても<br>やっぱりその実感がなくて
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070051")


	--★★ウレリー★★:でも『その人がいた跡』が少しでも残ってると<br>みんな余計に苦しくなっちゃったりして
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ウレリー★★:だから全部忘れようとした。ワタシも<br>逃げちゃった。最低だね
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070053")


	--★★ウレリー★★:なのに怖いんだ<br>もし自分が…って思ったら
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070054")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力

	--★★ウレリー★★:ワタシもいつかこうなるのかな<br>誰にも見向きされなくなっちゃうのかなって
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070055")


	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070057")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ウレリー★★:………教えてほしいくらい<br>戦いかた
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070058")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ウレリーは<br>お父さんがいなくなってしまったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070059")


	--★★ノワール★★:周りの人には<br>そうなってほしくないんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070060")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight(Actor002, 1.2, 0.8, 1.0, 1.0,1.0)
keep_delay_ik_lookat(Actor002, Actor001, "J_Head",1.0)
change_face(Actor002,"Surprise")
wait_time(1.7)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:戦ってるよ。ウレリーは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070062")

	change_face(Actor002,"Surprise")

	--★★ウレリー★★:…！<br>そうなのかな
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070063")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:戦ってるよ。ウレリーは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070064")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は学生生活の戦いかたを教えてもらった<br>学ぶことの多さを思い知らされたけど──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070065")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:人と関わって、教わること<br>怖くなくなってきた…気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070066")

	change_face(Actor002,"Sad")

	--★★ウレリー★★:………
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070068")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.1)
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ウレリー★★:ねえ、ノワールくん
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070069")


	--★★ウレリー★★:あした、ワタシ生徒会のオシゴトで<br>買い出しに行かなきゃならないんだケド…
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070070")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:手助けがいる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1070071")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ウレリー★★:………ほんと、たのもしい
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1070073")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
  load_particle_preload("content_prop_10104007", "10104007_PropModel", true, true)
  load_particle_preload("content_prop_10104014", "10104014_PropModel", true, true)
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_area_scene_preload(116047)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest(CameraAssetBundleName112041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
