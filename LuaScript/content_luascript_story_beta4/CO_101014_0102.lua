-- このluaスクリプトは、CO_101014_0102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_03","110191_03_h")
Include("content_adv_advsmall_110191_03","Template110191_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",125,CharaPos110191_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_004)
	InitializeTemplateRandomCamera110191_03()
	InitializeTemplate110191_03()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor003,"J_Head") 
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101014","001","101014001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
voice_play("VO_101040_sp_0001_1")
-- ▲直接出力

	--★★ケイ★★:ノワール、少しいいかね
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ケイ？俺に用か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:トリスタンを見なかったか？<br>預かりものがあってな。さがしているのだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020004")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:トリスタンだったら、さっき音楽室にいたけど<br>そのあとどこかへ行っちゃったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020005")

-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン2D★★:ボクがなんだって？
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","CO_101014_01020007")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Surp")
PlayActionDirect(Actor003,"to  Std_Surp")
wait_time(WAIT_TIME_SHORT) 
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,0.5, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
Appear(Actor002)
turn_lookat(Actor003,Actor002,0)
turn_lookat(Actor001,Actor002,0)
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor003,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.7, 0} , 1) 
lookat_delay_weight(Actor003, {0.4, 0.08, 0.7, 0} , 1)
keep_ik_lookat(Actor001,Actor002,"J_Head") 
keep_ik_lookat(Actor003,Actor002,"J_Head")
wait_time(WAIT_TIME_SHORT) 
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME) 
-- ▲直接出力

	--★★トリスタン★★:こんなところでウワサ話？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01020009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:するなとは言わないけどさ<br>せめてボクの耳に入らないところでしてくれる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01020010")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力

	--★★ケイ★★:ウワサ話をしていたわけではない<br>貴公を見なかったか聞いていただけだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020011")

-- ▼直接出力
PlayPartVoice("トリスタン", "納得")
-- ▲直接出力

	--★★トリスタン★★:ボクを？<br>…なんの用？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:先日貴公が行った支援活動の謝礼が届いている<br>貴公の働きに大いなる感謝を込めて、だそうだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "否定")
-- ▲直接出力

	--★★トリスタン★★:いらないよ。別に見返りが<br>欲しくてやってるわけじゃないし
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01020015")


	--★★トリスタン★★:ボクがやりたいからやってるだけ<br>感謝なんかされても困る
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定3")
-- ▲直接出力

	--★★ケイ★★:貴公にどのような意図があろうと
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020017")


	--★★ケイ★★:手助けしてもらった者が<br>してくれた者に感謝の念を抱くのは自然なことだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020018")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:そしてそれを形にしようとする思いもしかり<br>貴公は受け取ってやるべきだと思うがね
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020019")

-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:知らない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01020021")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera002)
end
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0006")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:とにかく、ボクには必要ないから<br>じゃあね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_01020022")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,0.5, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
turn_chara(Actor003,-115,0)
turn_chara(Actor001,90,0)
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor003,true)
wait_time(WAIT_TIME_SHORT)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:まったく<br>何度言えばわかってくれるのやら
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020024")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:えーっと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020026")

-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:なんだ、ノワール<br>まだいたのかね
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020028")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:呼び止めたのはあんただろう…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020029")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まあいいや。それよりトリスタンって<br>どこかで支援活動をやってるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020031")


	--★★ノワール★★:謝礼が届いてるとか言ってたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:バルバロイや野盗などに襲われ<br>被害が出た町や村の復興支援だ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ…<br>そういうのも円卓の騎士の任務に入るのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020034")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力

	--★★ケイ★★:いいや、円卓の騎士が直接出向くことは稀だ<br>大抵は兵士たちが支援物資を届けて終わる
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:自ら支援活動をしに行くトリスタンが<br>例外中の例外といえる
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020036")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:え？<br>トリスタンが自分からやってるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020037")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:そうだ。自身のキラーズである<br>イゾルデとともにな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020038")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:円卓の騎士が直々に出向いてくれるなんて<br>被災者たちも喜んでるんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020039")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:うむ。彼らの心の支えになっている<br>と言っても過言ではない
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020040")

-- ▼直接出力
PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:感謝の声や謝礼の品もたびたび届くのだが<br>なぜかトリスタンはいっさい受け取らん
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")

	--★★ケイ★★:人々の想いをきちんと受け取めるのも<br>騎士の務めのひとつだと思うのだが
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020042")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ふぅん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020043")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ケイ★★:いかん。こんなところで<br>無駄話をしている場合ではなかった
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "挨拶")
-- ▲直接出力

	--★★ケイ★★:私はこれで失礼する<br>貴公も騎士の務めにしっかり励むように
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101014_01020046")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera001)
end
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:はいはい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020047")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:誰に頼まれたわけでもなく<br>各地の支援活動に行っている、か…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020049")


	--★★ノワール★★:人との関わり合いを避けてるわけじゃないのかな<br>トリスタンのやつ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_01020050")

-- ▼直接出力
local trustParam = set_communication_acquired("トリスタン_コミュランク", "トリスタン_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101014","001","101014001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
