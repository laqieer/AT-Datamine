-- このluaスクリプトは、EA_004_055.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110111_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_005)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110111_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_007)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
-- ▼直接出力
lookat_weight(Actor001,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor001,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{0.75,0,-13.25})
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera007
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115114)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101054","005","101054005","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 on_active(Actor002)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat_position(Actor002,CharaPos110111_02_003[1],CharaPos110111_02_003[2],CharaPos110111_02_003[3],0)
slidemove(Actor002,CharaPos110111_02_003[1],CharaPos110111_02_003[2],CharaPos110111_02_003[3],2.0)
wait_time(2.0)
turn_chara(Actor002,CharaPos110111_02_003[4],0.2)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
set_enable_auto_lookat(Actor002,false)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット","肯定")
-- ▲直接出力

	--★★ランスロット★★:…にしても、考えたな<br>授業の内容をそのまま学園祭の出し物にするとは
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_004_0550006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:模擬店ならぬ模擬戦、か<br>学園祭の目玉企画になりそうだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_004_0550007")

-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうなってくれたら、苦労した甲斐もある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0550008")

-- ▼直接出力
setup_small_camera_start()
PlayActionDirect(Actor004,"to Std_Loop")
SkipDefaultMotion(Actor006)
PlayActionDirect(Actor006,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:色々大変だったみたいだな<br>まぁ、お前なら何とか出来ると思っていたが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_004_0550009")

-- ▼直接出力
play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ランスロット★★:やはり問題児の扱いは元問題児に任せるに限る
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_004_0550010")

-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだよそれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0550011")

-- ▼直接出力
PlayActionDirect(Actor006,"to Std_Loop")
SkipDefaultMotion(Actor008)
PlayActionDirect(Actor008,"to  Std_Talk")
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット","笑い")
-- ▲直接出力

	--★★ランスロット★★:冗談だ<br>お前なら彼女に寄り添ってやれると思った
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_004_0550012")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうやって真面目に褒められるのも<br>なんかむずがゆいんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0550013")

-- ▼直接出力
wait_time(0.4)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,346.32,0.6)
wait_time(0.6)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アダン","肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アダン★★:
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550015")

-- ▼直接出力
wait_time(0.4)
PlayActionDirect(Actor008,"to Std_Loop")
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,42.96779,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.4)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,79.46903,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:アダン先生
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0550017")

-- ▼直接出力
PlayPartVoice("アダン","悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アダン★★:あの娘は普通の少女らしい日常を送れなかった<br>…そして銀卓騎士である限り、これからも
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550018")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Talk")
change_face(Actor004,"Smile")
play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アダン","喜び")
-- ▲直接出力

	--★★アダン★★:だから今、友と笑う彼女を見ることができて<br>本当に嬉しく思います
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550019")

-- ▼直接出力
play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▲直接出力

	--★★アダン★★:
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550020")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アダン","0008")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アダン★★:青春はきっと、力になる<br>…自分も、そう信じていますから
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550021")

-- ▼直接出力
PlayPartVoice("アダン","笑い")
-- ▲直接出力

	--★★アダン★★:…ありがとうございます、ノワール<br>君のおかげです
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550023")

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
SkipDefaultMotion(Actor008)
PlayActionDirect(Actor008,"to  Std_Talk")
play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、俺はそんなたいしたことは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0550024")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★アダン★★:いえ。君に任せればきっと<br>上手くいくだろうと思っていました
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アダン","0009")
-- ▲直接出力

	--★★アダン★★:むしろ、君にしかできないだろうと
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550026")

	change_face(Actor001,"Normal")

	--★★ノワール★★:アダン先生…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0550027")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★アダン★★:アダンと呼んでくださって結構です<br>もう、先生は終わりですから
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550029")

-- ▼直接出力
setup_small_camera_start()
PlayActionDirect(Actor008,"to Std_Loop")
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アダン","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アダン★★:なんとか時間を作って<br>当日は学園祭にお邪魔させてもらうつもりです
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550030")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★アダン★★:もちろんエクセリアとリリアーナもつれて
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:アダンたちが見に来るなら<br>生半可な展示にはできないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0550032")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アダン","肯定2")
-- ▲直接出力

	--★★アダン★★:楽しみにしていますよ
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550033")


	--★★アダン★★:きっと学園祭の成功はログレスの再興を<br>勢いづけるものになるでしょうね
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アダン★★:学園の生徒たちに健やかな未来があらんことを<br>そして――
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550035")

-- ▼直接出力
wait_time(0.4)
setup_small_camera_start()
wait_time(0.4)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor007,0.6)
set_common_look_at(Actor003,Actor007)
wait_time(0.6)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.4)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor007,0.4)
set_common_look_at(Actor001,Actor007)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor007,0.4)
set_common_look_at(Actor002,Actor007)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor004,"to  Std_Talk")
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アダン","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アダン★★:皆が青春を謳歌できますよう<br>心から祈っています
	Talk(Actor003,"CHRNAME_ADAM","speech","L","EA_004_0550036")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 = RndCamera007
	InitializeLoad_Preload()
	load_area_scene_preload(115114)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101054","005","101054005","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
