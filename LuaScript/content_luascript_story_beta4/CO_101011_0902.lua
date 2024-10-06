-- このluaスクリプトは、CO_101011_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_001)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
tegami2 = setup_prop_object(10106003)
off_active(tegami2)
tegami_offset2 = {0,0,0,0,0,0}
 --set_common_look_at(Actor002,Actor001)
lookat_delay_weight(Actor002, {1.0, 0.05, 0.4, 0.2} ,0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
set_pos(lookoj,{2.49, 0.48, -1.7})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:あれからギネマウアさんとは<br>話をしたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020002")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力

	--★★ギネヴィア★★:それがね<br>気まずくて話しかけにくいってのもあるけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:ここのところ<br>お姉ちゃんの姿をあまり見かけないの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020004")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ひょっとして<br>わたしがガラス玉をなくしたことに気づいて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020005")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:怒って<br>わたしのことを避けてるのかなあ…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101011_09020008","CO_101011_09020009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーんありえない話じゃないかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネマウアさんって怒らせると怖いんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:大事なガラス玉をなくした仕返しを準備してたりしてな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020013")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:こ、怖いこと言わないでよ！お姉ちゃんがそんなことするはずないでしょ！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーんそれはないんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネマウアさんがなにより大切にしてるのはギネヴィアのはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:たとえガラス玉をなくしたことに気付いてもそこまで怒らないと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:そうだよね…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020019")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:とにかく今日も引き続きガラス玉を探しましょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020021")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
keep_delay_ik_lookat_object(Actor002,nil,"kara",0.6)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…あれ？<br>なんか手紙が入ってる
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020023")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_IN_OUT)
se_play("SE_ADV_MA_01105_28_Paper")
wait_time(IMAGE_TIME_WAIT_BEFORE + 0.5)
on_active(tegami2)
lookoj = create_object("tegami2")
set_pos_object(tegami2,2.34,0.818,-1.811)
lookat_position(Actor002,{2.34,0.818,-1.811})
turn_chara(Actor002, -175.633, 0)
setup_small_camera_start(RndCamera004)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:手紙？<br>なんて書いてあるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020025")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:「あなたの大切な宝物を預かっています<br>キャメリアード城で待っています」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020027")

-- ▼直接出力
wait_time(1.3)
setup_small_camera_start(Camera001)
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
 --keep_delay_ik_lookat(Actor002,Actor001, "J_Head", 0.5)
on_parent(tegami2,Actor002, "Loc_weapon_constrint_L", tegami_offset2)
	PlayAction(Actor002,"to ReadLetter")
lookat_weight(Actor002, {0.9, 0.07, 0.6, 0.5})
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:なんだって！？<br>ガラス玉を盗んだ犯人からの手紙か！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020028")

	open_select_window_tag(Actor001,"Normal","CO_101011_09020030","CO_101011_09020031","CO_101011_09020032")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(RndCamera001)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラス玉がなくなってからしばらく経つそこにこの手紙だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020034")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか罠があるとしか考えられない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…そうだとしてもわたし、キャメリアード城に行くよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:あなたが止めてもぜったいに行くから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…わかった俺もついていくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020038")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(RndCamera001)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:罠かもしれないけどキミの大切な宝物があるかもしれないんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020040")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だったらキャメリアード城に行こうなにがあっても俺がキミのことを守るから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020041")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ノワール…ありがとう！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020042")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
setup_small_camera_start(RndCamera001)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん…悪戯じゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020044")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なんでわざわざキャメリアード城まで俺たちを呼ぶんだ？その理由がわからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020045")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…悪戯じゃないと思う<br>だから、わたし行ってくるね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020046")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、おい！？<br>キミひとりで行かせるわけにはいかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020047")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start(Camera002)
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight_default(Actor002,1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:それにしても、この文字…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:見覚えがあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09020050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:ううん、気のせいだと思うキャメリアード城に急ごう
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09020051")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ギネヴィア_ランクアップ9_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10106003)
tegami_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
