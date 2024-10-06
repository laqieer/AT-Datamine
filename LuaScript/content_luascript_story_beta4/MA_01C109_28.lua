-- このluaスクリプトは、MA_01C109_28.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_001)
	Camera002 = SetTemplate("Actor002",-180,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003, {-0.68,0,3.99})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("モルドレッド","挨拶")
-- ▲直接出力

	--★★モルドレッド★★:癪に障るよな？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280002")


	--★★モルドレッド★★:腑抜けが<br>上に居座ってンのが
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280003")

-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…腑抜け？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_280004")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,77.8,0.8)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド","肯定")
-- ▲直接出力

	--★★モルドレッド★★:アーサーを引きずり降ろさねえか
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280005")

-- ▼直接出力
 --PlayPartVoice("ノワール","怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:それは…俺にする質問か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_280007")

-- ▼直接出力
 --PlayPartVoice("モルドレッド","笑い")
-- ▲直接出力

	--★★モルドレッド★★:歴史を担う継承者様にゃ<br>お気に召さないプランだろうが…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280008")


	--★★モルドレッド★★:ログレスにとっては<br>元々ゲストだったてめえだから聞いてンだよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("モルドレッド","挨拶")
-- ▲直接出力

	--★★モルドレッド★★:…どう思う、アーサーのヤロウのこと
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280010")

	open_select_window_tag(Actor001,"Normal","MA_01C109_280011","MA_01C109_280012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうって…<br>尊敬できる王だと思うけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_280014")

-- ▼直接出力
 --PlayPartVoice("モルドレッド","喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:ハ！<br>節穴かよ、てめえの目はよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クラリス","激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★クラリス★★:モルくん～ノワールくんは人間ですよ～<br>木じゃないです～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_280016")

-- ▼直接出力
 --PlayPartVoice("モルドレッド","怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:うるせえ！話に入ってくんな！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ここのところ<br>なにか様子がおかしいと思ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_280019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クラリス","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:はい、最近のアーサー様は<br>ちょっと変です
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_280020")

	change_face(Actor003,"Normal")

	--★★クラリス★★:いつも大聖堂にいらっしゃるときは<br>たくさんのホットドッグを抱えてくるのに
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_280021")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("クラリス","落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クラリス★★:…もう、来てくれなくなりました
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_280022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
 --PlayPartVoice("モルドレッド","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:これまでのアーサーはよ<br>反吐が出るくらい甘っちょろいヤツだったが
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280024")


	--★★モルドレッド★★:その言葉の裏には<br>自信と王としての威厳があった
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280025")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("クラリス","悩む")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:モルくん、甘い物食べ過ぎて<br>吐いちゃったんですか？
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_280026")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera007)
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド","挨拶")
-- ▲直接出力

	--★★モルドレッド★★:…あいつは<br>この場にいないものと思っとけ、いいな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:今のアーサーから感じられるのは<br>まったくの別モン、その正体まではわからねえが
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280028")

	open_select_window_tag(Actor001,"Normal","MA_01C109_280029","MA_01C109_280030")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まさか<br>アーサーが俺に敵意を抱いているとか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_280032")

-- ▼直接出力
 --PlayPartVoice("モルドレッド","肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:オレの勘違いで済めばいいがよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280033")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クラリス","肯定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クラリス★★:わたしもよく勘違いして<br>モルくんに叱られます
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_280034")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:おめえは静かにしてろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280035")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:忠告ありがとう<br>気にかけてくれてたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_280037")

-- ▼直接出力
 --PlayPartVoice("モルドレッド","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:一度でも疑いを持ったら<br>今までどおりに相手を見られなくなるだろ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280038")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:そうやって王サマのアンチを増やしてえだけだ<br>そのほうが愉快でイイ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280040")

	goto Block2end

::Block2end::
-- ▼直接出力
Hide(Actor003)
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:てめえが<ruby=ゲシュタルト・シフト>ＧＳ</ruby>してからだ<br>なにかが<dot>変わった</dot>
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280042")

-- ▼直接出力
 --PlayPartVoice("モルドレッド","肯定3")
-- ▲直接出力

	--★★モルドレッド★★:もしくはうさんくせえ馬鹿なフリを<br><dot>やめた</dot>のか
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280044")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-13,0.8)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:…クラリス？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280046")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あの…さっき<br>ネコを追いかけて向こうへ行ったけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_280047")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:ハーッ…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280048")

-- ▼直接出力
 --PlayPartVoice("モルドレッド","挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:ともかくアーサーには<br>気を許さねえほうがいい
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:王として<br>腑抜けちまったわけじゃなきゃあ──
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280051")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:ハラにイチモツあるんじゃねえの
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C109_280052")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
