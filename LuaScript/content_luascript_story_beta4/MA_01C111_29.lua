-- このluaスクリプトは、MA_01C111_29.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",85,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_005)
	Camera003 = SetTemplate("Actor003",70,CharaPos110141_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_006)
	Camera004 = SetTemplate("Actor004",90,CharaPos110141_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera007 = SetTemplate("Actor007",160,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
 --arufa = 0.055
--setup_small_camera_resetting(Actor005,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor005,"J_Head")
keep_ik_lookat(Actor002,Actor005,"J_Head")
keep_ik_lookat(Actor003,Actor005,"J_Head")
keep_ik_lookat(Actor004,Actor005,"J_Head")
keep_ik_lookat(Actor005,Actor001,"J_Head")
keep_ik_lookat(Actor006,Actor005,"J_Head")
keep_ik_lookat(Actor007,Actor005,"J_Head")
lookat_weight(Actor001,0.7,0.03,0.7,0)
lookat_weight(Actor002,0.6,0.03,0.7,0)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ローラ","挨拶")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ローラ★★:…ルーシャス様を…みんなを助けて…
	Talk(Actor005,"CHRNAME_LOLA","speech","L","MA_01C111_290002")

-- ▼直接出力
 --PlayPartVoice("イゾルデ","肯定")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★イゾルデ★★:今は眠りなさい
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_290003")

-- ▼直接出力
reserve_eyesync(Actor005,"Close")
-- ▲直接出力

	--★★ローラ★★:………
	Talk(Actor005,"CHRNAME_LOLA","speech","L","MA_01C111_290004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to  Std_Sad01")
 --PlayPartVoice("ラシア","落胆")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★ラシア★★:ローラ…
	Talk(Actor007,"CHRNAME_RASIA","speech","L","MA_01C111_290005")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("イゾルデ","落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★イゾルデ★★:ひどい状態だわ<br>ここまでたどり着いたのが奇跡ね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_290006")


	--★★イゾルデ★★:なにかに追われてきたのかしら<br>バルバロイ…もしくは魔女…？
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01C111_290007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera007)
keep_delay_ik_lookat(Actor007,Actor004,"J_Head",1)
keep_delay_ik_lookat(Actor006,Actor004,"J_Head",1)
PlayActionDirect(Actor007,"to  Std_Joy")
turn_chara(Actor007,-165,0.3)
set_rot(Actor006,{0,-145,0})
 --PlayPartVoice("ラシア","悲しみ")
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★ラシア★★:そんな…ヴェルナルス様…
	Talk(Actor007,"CHRNAME_RASIA","speech","L","MA_01C111_290008")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
keep_delay_ik_lookat(Actor001,Actor006,"J_Head",1)
keep_delay_ik_lookat(Actor002,Actor006,"J_Head",1)
keep_delay_ik_lookat(Actor003,Actor006,"J_Head",1)
keep_delay_ik_lookat(Actor004,Actor006,"J_Head",1)
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★フレン★★:ルーシャスくんを助けにいかなきゃ…
	Talk(Actor006,"CHRNAME_FREN","speech","L","MA_01C111_290009")

-- ▼直接出力
set_enable_auto_lookat(Actor006,true)
set_enable_auto_lookat(Actor007,true)
 --PlayPartVoice("ランスロット","挨拶")
-- ▲直接出力

	--★★ランスロット★★:待て、フレン、ラシア
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_290010")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力

	--★★フレン★★:…でも…！
	Talk(Actor006,"CHRNAME_FREN","speech","L","MA_01C111_290011")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ランスロット","否定")
-- ▲直接出力

	--★★ランスロット★★:お前たちだけが行ったところで<br>ルーシャスの力にはなれまい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_290012")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor006,true)
set_enable_auto_lookat(Actor007,true)
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:魔女たちは<br>俺とディナタンを呼んでいるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_290013")

-- ▼直接出力
set_enable_auto_lookat_all(true)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Talk")
 --PlayPartVoice("ギネヴィア","悩む")
-- ▲直接出力

	--★★ギネヴィア★★:手を組んだはずの魔女に裏切られ<br>背後にはアーサーの軍勢も目を光らせている
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_290014")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力

	--★★ギネヴィア★★:ノワールたちを呼んでこられないと<br>民もろとも命を奪われるかもしれない
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_290015")


	--★★ギネヴィア★★:ローマの皇太子も形無しね<br>ま、自業自得な気もするけど
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_290016")

-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定3")
-- ▲直接出力

	--★★ランスロット★★:だがローマを味方につける<br>絶好の機会ともいえる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_290017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
set_common_look_at(Actor003,Actor002)
PlayActionDirect(Actor003,"to Std_Loop")
turn_chara(Actor003,115,0.5)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,140,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
 --PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:どういうこと？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_290018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(true)
 --PlayPartVoice("ランスロット","肯定")
-- ▲直接出力

	--★★ランスロット★★:俺たちは多くを失った<br>今の俺達には戦力が必要だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_290019")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力

	--★★ランスロット★★:彼女の言うように、魔女が聖杯を<br>狙っているとしているならなおさら
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_290020")

	open_select_window_tag(Actor001,"Normal","MA_01C111_290021","MA_01C111_290022")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:敵の敵は味方ってわけか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_290024")

	change_face(Actor006,"Surprise")

	--★★フレン★★:…！
	Talk(Actor006,"CHRNAME_FREN","speech","L","MA_01C111_290025")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ギネヴィア★★:…ルーシャスを助けるの？<br>気が乗らないんだけど
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_290026")

-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:恩を売りに行くってことだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_290027")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor006)
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor007,false)
turn_chara(Actor001,104,0.5)
 --PlayPartVoice("フレン","肯定2")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★フレン★★:…なら、私も行く！
	Talk(Actor006,"CHRNAME_FREN","speech","L","MA_01C111_290028")

	change_face(Actor006,"Anger")

	--★★フレン★★:ルーシャスくんには<br>言ってやりたいことが山ほどあるから！
	Talk(Actor006,"CHRNAME_FREN","speech","L","MA_01C111_290029")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("ラシア","肯定3")
-- ▲直接出力
	change_face(Actor007,"Anger")

	--★★ラシア★★:私も行きます<br>ヴェルナルス様を助けなきゃ…！
	Talk(Actor007,"CHRNAME_RASIA","speech","L","MA_01C111_290030")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ルーシャスが<br>これまでにやってきたことを考えたら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_290032")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そうカンタンには割り切れない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_290033")

	change_face(Actor001,"Sad")

	--★★ノワール★★:コルベニック城での一件は<br>ランスロットたちも知ってるだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_290034")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:正直、わたしも気は乗らないけど…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_290035")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor006)
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor007,false)
set_rot(Actor001,{0,104,0})
 --PlayPartVoice("フレン","悲しみ")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★フレン★★:…私はその場所にいなかったし<br>彼の考えのすべてがわかるわけじゃない
	Talk(Actor006,"CHRNAME_FREN","speech","L","MA_01C111_290036")

	change_face(Actor006,"Sad")

	--★★フレン★★:でも、ルーシャスくんもルーシャスくんなりの<br>貫き通したい正義があって
	Talk(Actor006,"CHRNAME_FREN","speech","L","MA_01C111_290037")

	change_face(Actor006,"Sad")

	--★★フレン★★:それはノワールくんたちと<br>このあともぶつかるものかもしれないけど
	Talk(Actor006,"CHRNAME_FREN","speech","L","MA_01C111_290038")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Anger")

	--★★フレン★★:平和な世界を作りたいという<br>根っこの部分はみんな同じだと思うから
	Talk(Actor006,"CHRNAME_FREN","speech","L","MA_01C111_290039")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("ラシア","肯定3")
-- ▲直接出力
	change_face(Actor007,"Anger")

	--★★ラシア★★:だからヴェルナルスさ…大将軍も<br>ルーシャス様に従っているんだと思います
	Talk(Actor007,"CHRNAME_RASIA","speech","L","MA_01C111_290040")

	change_face(Actor007,"Sad")

	--★★ラシア★★:お願い、ノワールさん<br>ルーシャス様たちを助けてあげて
	Talk(Actor007,"CHRNAME_RASIA","speech","L","MA_01C111_290042")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ノワール","悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ふたりとも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_290044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(true)
 --PlayPartVoice("ランスロット","肯定")
-- ▲直接出力

	--★★ランスロット★★:まとまったようだ<br>では、皆に話をしなければ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_290045")

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
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
