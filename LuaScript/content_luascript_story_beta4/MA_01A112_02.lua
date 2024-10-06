-- このluaスクリプトは、MA_01A112_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_002)
	Camera004 = SetTemplate("Actor004",0,CharaPos110031_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_001)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_pos(Actor002,{8.85,0,-24.95})
set_rot(Actor002,{0,90,0})
set_pos(Actor003,{8,0,-25.5})
set_rot(Actor003,{0,90,0})
set_pos(Actor004,{11.6,0,-28.7})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor003,false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,{12.85,0,-24.95},1)
wait_time(0.3)
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003,{12,0,-25.5},1)
wait_time(0.4)
turn(Actor002,0,141,0,0.3)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.3)
turn(Actor003,0,116,0,1)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:兄さん！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A112_020002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:忙しそうだな、手伝おうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_020003")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "否定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:オニーサンは手当てされる側だろーが！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A112_020004")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A112_020006","MA_01A112_020007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
change_face(Actor002,"Normal")
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ちょっと病室で休ませて欲しい…<br>とは思ったんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_020009")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:ベッドは満杯だよ！<br>帰って寝てな！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A112_020010")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:冗談だよ。別に必要ない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_020011")

	change_face(Actor001,"Smile")

	--★★ノワール★★:なんたって父さ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_020012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロットやブライアンに<br>鍛えられてきたからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:感謝しなくちゃね<br>ランス兄ちゃんたちに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A112_020014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
change_face(Actor002,"Normal")
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いつも以上に忙しそうだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_020016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:全然病室の手が回ってなくて<br>でも、でも大丈夫だよ、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A112_020017")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:お気遣いは嬉しいけどさ<br>この多忙さにオニーサン巻き込むワケいかねえな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A112_020018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_020019")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
se_play("SE_ADV_MA_01B109_11_Door")
wait_time(1.0)
Appear(Actor004)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{11.6,0,-26.3},1.8)
wait_time(1.5)
turn(Actor004,0,80,0,0.3)
PlayActionDirect(Actor004,"to Std_Loop")
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1)
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
set_rot(Actor003,{0,155,0})
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…エレインの、容体は…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_020021")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera004)
set_rot(Actor002,{0,180,0})
set_enable_auto_lookat_all(true)
 --PlayPartVoice("イゾルデ", "悩む")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★イゾルデ★★:とても面会ができるような状態じゃないわね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01A112_020023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★イゾルデ★★:聞いたわ<br>ギネヴィアの身代わりになったと
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01A112_020025")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:エレインがいなかったら<br>今頃は──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_020026")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
 --PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:どーしよーもねえ危機的状況で<br>エレインが根性見せたってだけだろ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A112_020027")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:自分を責めないでね、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A112_020028")


	--★★ディナタン★★:誰もそんなことは望んでない…<br>…今は身体を休めて、出来るだけ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A112_020029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ…、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_020030")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力

	--★★イゾルデ★★:モルガン先生のボイコット癖には<br>困ったものね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01A112_020031")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Angry")
turn_chara(Actor003,180,0.3)
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:せんせはそんな人じゃねえよ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A112_020032")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★イゾルデ★★:そう信じてくれる人がいるのは貴重ね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01A112_020033")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor004,1)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:ああ、早く帰って来て<br>病室のパニックを収めてもらえないものかしら
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","MA_01A112_020034")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor004)
set_rot(Actor002,{0,-165,0})
set_rot(Actor003,{0,116,0})
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:いつ帰って来てもいいように<br>病室は綺麗にしておこうね、マァル？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A112_020036")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:アタシが散らかしてるみてえにゆーな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A112_020037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:…整理つけてる場合でもねえし
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A112_020038")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
MobsNo = 1
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
