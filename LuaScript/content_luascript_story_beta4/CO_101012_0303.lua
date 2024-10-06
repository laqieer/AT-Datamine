-- このluaスクリプトは、CO_101012_0303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マルディサント","0019")
-- ▲直接出力

	--★★マルディサント★★:はあ？ラブレターの返事書くのを手伝えだぁ？<br>なんでアタシがそんなこと！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_03030002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0042")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:お願い！貴方にしか頼めないの！<br>モルガン先生も貴方が適任だって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03030004")

	change_face(Actor003,"Surprise")

	--★★マルディサント★★:…モルガンセンセが？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_03030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:うん。「文章と言えばマルディサントだから<br>手伝ってもらったらどう？」って！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03030006")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:「マルディサントの書くお話は素敵だから<br>手紙を書かせてもきっと最高よ～」って！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03030007")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ、そうなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_03030008")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★マルディサント★★:…モルガンせんせってば、余計なことを
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_03030010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:モルガンせんせにそう言われちゃ仕方ねえな<br>手伝ってやるよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_03030012")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:やった！ありがとう！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03030013")

-- ▼直接出力
	
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…よし、これで全部お返事書き終わった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03030015")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:お疲れ様、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_03030016")

-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:おい、アタシにも言えっての！<br>この人数の返事考えるの、すげえ大変だったぞ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_03030017")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はは…マルディサントもお疲れ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_03030018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:マルディサント、本当にありがとう<br>おかげで私の想いがちゃんと伝わると思う
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03030019")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:お付き合いとかはできないけど、<br>こうやって気持ちを伝えてくれるのは嬉しいから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03030021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:だからちゃんと向き合ってお返事しないとね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03030022")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:ハイハイ。いい子ちゃんなこって
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_03030023")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:こりゃまた、妹さんのファンが増えちまうなあ<br>オニーサン？<br>?
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_03030024")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
change_face(Actor001,"Sad")
PlayActionDirect(Actor001,"to  Std_Worry")
wait_time(2)
setup_small_camera_end(Camera001)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("ディナタン_コミュランク", "ディナタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
